using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

namespace STK_Service
{
    public static class ExtendMethods
    {
        public static void AddInOutParameter(this SqlDatabase db, DbCommand command, string name, SqlDbType dbType, int size, object value)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, value);
        }

        public static void AddInOutParameter(this SqlDatabase db, DbCommand command, string name, SqlDbType dbType, int size)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, DBNull.Value);
        }
    }

    //public class WcfDatabase
    //{
    //    public static SqlDatabase db = DatabaseFactory.CreateDatabase("Connect_DB") as SqlDatabase;

    //    public static log4net.ILog log = log4net.LogManager.GetLogger("LogFileAppender");

    //    public static void 登记错误信息(string @标题, string @模块, string @描述)
    //    {

    //        DbCommand dbCommand = db.GetStoredProcCommand("P_XT_登记错误信息");

    //        db.AddInParameter(dbCommand, "@标题", SqlDbType.NVarChar, @标题);
    //        db.AddInParameter(dbCommand, "@模块", SqlDbType.NVarChar, @模块);
    //        db.AddInParameter(dbCommand, "@描述", SqlDbType.NVarChar, @描述);

    //        db.ExecuteNonQuery(dbCommand);

    //        //System.Diagnostics.EventLog log = new System.Diagnostics.EventLog("AppName ");
    //        //log.WriteEntry("Exception   occured:   " + e.ToString(), System.Diagnostics.EventLogEntryType.Warning); 

    //        //System.Console.WriteLine(string.Format("标题={0}, 模块={1}, 描述={2}", @标题, @模块, @描述));


    //    }

        //public static void AddInOutParameter(DbCommand command, string name, SqlDbType dbType, int size, object value)
        //{
        //    db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, value);
        //}

        //public static void AddInOutParameter(DbCommand command, string name, SqlDbType dbType, int size)
        //{
        //    db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, DBNull.Value);
        //}

   // }

    #region 存储过程代理类
    
    /// <summary>
    /// 根据数据库中的表sysobjects取其存储过程的出入口参数，作为当前存储过程的出入口参数，入口参数的值取自模型属性的值，出口参数需要类型 
    /// 依赖条件：需要创建一个与数据库表一致的实体类（属性与表字段一致，顺序不限）
    /// </summary>
    public static class ProcProxy
    {
        public static SqlDatabase db = null;

        public static void ExecuteNoQuery(string procname, ref object model)
        {
            DbCommand dbcmd = db.GetStoredProcCommand(procname);
            dbcmd.CommandTimeout = 300;
            // 利用模型的值为存储过程出入口参数赋值（注：模型的值由客户端传递）
            ProcProxy.AddInParameterToDbCommand(procname, dbcmd, ref model);
            db.ExecuteDataSet(dbcmd);
            // 取得存储过程出口参数为模型赋值
            ProcProxy.GetOutParameterFromDbCommand(procname, dbcmd, ref model);
        }
        
        public static DataSet ExecuteDataSet(string procname, object model)
        {
            DbCommand dbcmd = db.GetStoredProcCommand(procname);
            dbcmd.CommandTimeout = 300;
            // 为存储过程出入口参数赋值
            if (model != null) ProcProxy.AddInParameterToDbCommand(procname, dbcmd, ref model);
            return db.ExecuteDataSet(dbcmd);
        }

        public static DataSet ExecuteDataSet(string procname, ref object model)
        {
            DbCommand dbcmd = db.GetStoredProcCommand(procname);
            dbcmd.CommandTimeout = 300;
            // 为存储过程出入口参数赋值
            ProcProxy.AddInParameterToDbCommand(procname, dbcmd, ref model);
            DataSet dst = db.ExecuteDataSet(dbcmd);
            // 取得存储过程出口参数为模型赋值
            ProcProxy.GetOutParameterFromDbCommand(procname, dbcmd, ref model);
            return dst;
        }

        private static void AddInParameterToDbCommand(string procname, DbCommand dbcmd, ref object model)
        {
            DataTable table = sys_procparam(procname).Tables[0];
            // 循环读取每个参数并用模型赋值
            foreach (DataRow row in table.Rows)
            {
                string p_name = row["p_name"].ToString();
                string type = row["p_type"].ToString();
                SqlDbType p_type = ProcParamTypeToSqlDbType(type);
                int p_isount = int.Parse(row["p_isout"].ToString());
                // 入口参数，其值取模型的值
                if (p_isount == 0)
                {
                    // 取模型的值
                    object p_value = GetModelValue(model, p_type, p_name.Substring(1));
                    db.AddInParameter(dbcmd, p_name, p_type, p_value);
                }
                // 出口参数，不用赋值，但要取其长度
                else
                {
                    object p_value = GetModelValue(model, p_type, p_name.Substring(1));
                    int p_length = int.Parse(row["p_length"].ToString());
                    db.AddInOutParameter(dbcmd, p_name, p_type, p_length, p_value);
                }
            }
        }

        // 取其存储过程返回值为模型赋值 注：此函数必须放于存储过程执行后的位置
        private static void GetOutParameterFromDbCommand(string procname, DbCommand dbcmd, ref object model)
        {
            if (procname == "" || dbcmd == null || model == null) return;
            DataTable table = sys_procparam(procname).Tables[0];
            // 循环读取每个参数并用模型赋值
            foreach (DataRow row in table.Rows)
            {
                string p_name = row["p_name"].ToString();
                string type = row["p_type"].ToString();
                int p_isount = int.Parse(row["p_isout"].ToString());
                // 出口参数，取其返回值给模型赋值
                if (p_isount == 1)
                {
                    object p_value = db.GetParameterValue(dbcmd, p_name);
                    if (p_value is DBNull) continue;
                    p_name = p_name.Substring(1);
                    SetModelValue(model, p_name, p_value);
                }
            }
        }

        // 取得指定存储的入口参数并以DataSet返回
        private static DataSet sys_procparam(string pname)
        {
            DbCommand dbcmd = db.GetStoredProcCommand("P_SYS_GetPmrList_Proc");
            db.AddInParameter(dbcmd, "@pname", SqlDbType.NVarChar, pname);
            return db.ExecuteDataSet(dbcmd);
        }

        // 根据模型类型得到相应的数据库类型
        private static SqlDbType ProcParamTypeToSqlDbType(string ptype)
        {
            SqlDbType result = SqlDbType.NVarChar;
            switch (ptype)
            {
                case "char":
                    result = SqlDbType.Char;
                    break;
                case "varchar":
                    result = SqlDbType.VarChar;
                    break;
                case "nchar":
                    result = SqlDbType.NChar;
                    break;
                case "nvarchar":
                    result = SqlDbType.NVarChar;
                    break;
                case "text":
                    result = SqlDbType.Text;
                    break;
                case "int":
                    result = SqlDbType.Int;
                    break;
                case "smallint":
                    result = SqlDbType.SmallInt;
                    break;
                case "money":
                    result = SqlDbType.Money;
                    break;
                case "numeric":
                case "decimal":
                    result = SqlDbType.Decimal;
                    break;
                case "float":
                    result = SqlDbType.Float;
                    break;
                case "datetime":
                    result = SqlDbType.DateTime;
                    break;
                case "bit":
                    result = SqlDbType.Bit;
                    break;
                case "smallmoney":
                    result = SqlDbType.SmallMoney;
                    break;
            }
            return result;
        }

        // 得到存储过程名称读取得到对应的模型名
        private static object GetModelValue(object model, SqlDbType p_type, string p_name)
        {
            object result = null;
            System.Reflection.PropertyInfo[] properties = model.GetType().GetProperties();
            foreach (System.Reflection.PropertyInfo attr in properties)
            {
                if (attr.Name.ToLower() == p_name.ToLower())
                {
                    result = attr.GetValue(model, null);
                    //处理数据库DateTime类型的范围问题
                    if ((p_type == SqlDbType.DateTime) && (((DateTime)result).Year < 1753)) result = null;

                    break;
                }
            }
            return result;
        }

        private static void SetModelValue(object model, string p_name, object value)
        {
            System.Reflection.PropertyInfo[] properties = model.GetType().GetProperties();
            foreach (System.Reflection.PropertyInfo attr in properties)
            {
                if (attr.Name.ToLower() == p_name.ToLower())
                {
                    attr.SetValue(model, value, null);
                    break;
                }
            }
        }
    }

    #endregion


}