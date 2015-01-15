using System;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Collections.Generic;
using System.ServiceModel;
using System.Xml.Linq;
using System.Runtime.Serialization;
using System.IO;
using System.Reflection;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace STK_Service
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    public class WS_STK : IWS_STK
    {
        public WS_STK()
        {
            //初始化
            ProcProxy.db = AppDB;
        }

        //数据库连接
        private static SqlDatabase AppDB = (SqlDatabase)DatabaseFactory.CreateDatabase("Connect_DB");

        #region 通用模块

        //public DataSet ExecuteDataSet(string sql)
        //{
        //    DbCommand dbcmd = AppDB.GetStoredProcCommand("p_sys_execsql");
        //    AppDB.AddInParameter(dbcmd, "@sql", SqlDbType.NVarChar, sql);
        //    return AppDB.ExecuteDataSet(dbcmd);
        //}
        //public int ExecuteNoQuery(string sql)
        //{
        //    DbCommand dbcmd = AppDB.GetStoredProcCommand("p_sys_execsql");
        //    AppDB.AddInParameter(dbcmd, "@sql", SqlDbType.NVarChar, sql);
        //    return AppDB.ExecuteNonQuery(dbcmd);
        //}

        #endregion

        #region 系统管理

        /// <summary>
        /// 测试连接
        /// </summary>
        public string SYS_Test(string ATestName)
        {
            if (ATestName.Length > 4)
            {
                string KCcode = ATestName.Substring(0, 3);

                DbCommand dbcmd = AppDB.GetStoredProcCommand("P_BAS_仓库_POS");
                AppDB.AddInParameter(dbcmd, "@仓库编码", SqlDbType.Char, KCcode);
                AppDB.AddInParameter(dbcmd, "@POS版本", SqlDbType.VarChar, ATestName);
                AppDB.ExecuteNonQuery(dbcmd);                
            }
            return ATestName;
        }

        /// <summary>
        /// 系统登录
        /// </summary>
        public void SYS_Login(ref DataType_User model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_Login", ref m);
        }

        /// <summary>
        /// 系统登录用户的菜单
        /// </summary>
        public DataSet SYS_Login_Menu(ref DataType_User model)
        {
            object m = model;
            return ProcProxy.ExecuteDataSet("P_SYS_Login_Menu", ref m);
        }

        /// <summary>
        /// 退出登录
        /// </summary>
        public void SYS_Logout(DataType_User model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_Logout", ref m);
        }

        /// <summary>
        /// 用户列表
        /// </summary>
        public DataSet Sys_User_List(DataType_User model)
        {
            return ProcProxy.ExecuteDataSet("P_SYS_User_List", model);
        }

        /// <summary>
        ///  用户编辑
        /// </summary>
        public void Sys_User_Edit(ref DataType_User model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_User_Edit", ref m);
        }

        /// <summary>
        /// 角色列表
        /// </summary>
        public DataSet Sys_Role_List(DataType_Role model)
        {
            return ProcProxy.ExecuteDataSet("P_SYS_Role_List", model);
        }

        /// <summary>
        ///  角色编辑
        /// </summary>
        public void Sys_Role_Edit(ref DataType_Role model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_Role_Edit", ref m);
        }

        /// <summary>
        /// 菜单列表
        /// </summary>
        public DataSet Sys_Menu_List(int ARoleID)
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("P_SYS_Menu_List");
            AppDB.AddInParameter(dbcmd, "@RoleID", SqlDbType.Int, ARoleID);
            return AppDB.ExecuteDataSet(dbcmd);
        }

        /// <summary>
        /// 参数读取
        /// </summary>
        public void SYS_Param_Get(ref DataType_Param model)
        {
            DataTable table = ProcProxy.ExecuteDataSet("P_SYS_Param_Get", model).Tables[0];
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(table, model);
            //读取应用程序的版本号
            model.WSVersion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        /// <summary>
        /// 参数设置
        /// </summary>
        public void SYS_Param_Set(ref DataType_Param model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_Param_Set", ref m);
        }

        /// <summary>
        /// 表格读取
        /// </summary>
        public void SYS_Grid_Get(ref DataType_Grid model)
        {
            DataTable table = ProcProxy.ExecuteDataSet("P_SYS_Grid_Get", model).Tables[0];
            //
            TY.Helper.FormHelper.DataBinding_DataSourceToModel(table, model);
        }

        /// <summary>
        /// 表格设置--保存用户对表格配置
        /// </summary>
        public void SYS_Grid_Set(ref DataType_Grid model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_SYS_Grid_Set", ref m);
        }

        public string GetTableDef(string tableid)
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("P_SYS_Grid_Get");
            AppDB.AddInParameter(dbcmd, "@GridName", SqlDbType.NVarChar, tableid);
            DataTable table = AppDB.ExecuteDataSet(dbcmd).Tables[0];
            if (table.Rows.Count > 0)
            { return table.Rows[0]["GridDefine"].ToString(); }
            else
            { return ""; }
        }
        #endregion        

        #region 库存管理
        #region 基础信息
        /// <summary>
        /// 会计期间
        /// </summary>
        /// <param name="ServiceTime_B"></param>
        /// <param name="ServiceTime_E"></param>
        public DataSet BAS_会计期间_List(DataType_会计期间 model)
        {
            return ProcProxy.ExecuteDataSet("P_BAS_会计期间_List", model);
        }
        public void BAS_会计期间_Edit(ref DataType_会计期间 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_BAS_会计期间_Edit", ref m);
        }
        /// <summary>
        /// 存货
        /// </summary>
        public DataSet BAS_存货_List(DataType_存货 model)
        {
            return ProcProxy.ExecuteDataSet("P_BAS_存货_List", model);
        }
        public void BAS_存货_Edit(ref DataType_存货 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_BAS_存货_Edit", ref m);
        }
        /// <summary>
        /// 存货_类别 
        /// </summary>
        public DataSet BAS_存货_类别_List(DataType_存货_类别 model)
        {
            return ProcProxy.ExecuteDataSet("P_BAS_存货_类别_List", model);
        }
        public void BAS_存货_类别_Edit(ref DataType_存货_类别 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_BAS_存货_类别_Edit", ref m);
        }
        public DataSet BAS_存货_类别_Down(ref DataType_存货_类别 model)
        {
            object m = model;
            return ProcProxy.ExecuteDataSet("P_BAS_存货_类别_Down", ref m);
        }

        /// <summary>
        /// 储物箱
        /// </summary>
        public DataSet BAS_储物箱_List(DataType_仓库 model)
        {
            return ProcProxy.ExecuteDataSet("P_BAS_储物箱_List", model);
        }
        public void BAS_储物箱_Edit(ref DataType_仓库 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_BAS_储物箱_Edit", ref m);
        }

        /// <summary>
        /// 货架
        /// </summary>
        public DataSet BAS_货架_List(DataType_仓库 model)
        {
            return ProcProxy.ExecuteDataSet("P_BAS_货架_List", model);
        }
        public void BAS_货架_Edit(ref DataType_仓库 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_BAS_货架_Edit", ref m);
        }
        
        /// <summary>
        /// 仓库
        /// </summary>
        public DataSet BAS_仓库_List(DataType_仓库 model)
        {
            return ProcProxy.ExecuteDataSet("P_BAS_仓库_List", model);
        }
        public void BAS_仓库_Edit(ref DataType_仓库 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_BAS_仓库_Edit", ref m);
        }
        public DataSet BAS_仓库_类型_List()
        {
            DbCommand dbcmd = AppDB.GetStoredProcCommand("P_BAS_仓库_类型_List");
            return AppDB.ExecuteDataSet(dbcmd);
        }
        /// <summary>
        /// 供应商 
        /// </summary>
        public DataSet BAS_供应商_List(DataType_供应商 model)
        {
            return ProcProxy.ExecuteDataSet("P_BAS_供应商_List", model);
        }
        public void BAS_供应商_Edit(ref DataType_供应商 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_BAS_供应商_Edit", ref m);
        }

        /// <summary>
        /// 期初
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public DataSet BAS_期初库存_List(DataType_库存管理 model)
        {
            return ProcProxy.ExecuteDataSet("P_BAS_期初库存_List", model);
        }
        public void BAS_期初库存_Edit(ref DataType_库存管理 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_BAS_期初库存_Edit", ref m);
        }
        #endregion
        #region 库存管理       
        /// <summary>
        /// 出库
        /// </summary>
        public DataSet STK_库存出库_List(DataType_库存管理 model)
        {
            return ProcProxy.ExecuteDataSet("P_STK_库存出库_List", model);
        }
        public void STK_库存出库_Edit(ref DataType_库存管理 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_STK_库存出库_Edit", ref m);
        }
        /// <summary>
        /// 入库
        /// </summary>
        public DataSet STK_库存入库_List(DataType_库存管理 model)
        {
            return ProcProxy.ExecuteDataSet("P_STK_库存入库_List", model);
        }
        public void STK_库存入库_Edit(ref DataType_库存管理 model)
        {
            object m = model;
            ProcProxy.ExecuteNoQuery("P_STK_库存入库_Edit", ref m);
        }
        #endregion
        #region M04_库存报表
        public DataSet STK_库存分布_List(DataType_库存分布 model)
        {
            return ProcProxy.ExecuteDataSet("P_STK_库存分布_List", model);
        }
        /// <summary>
        /// 账单
        /// </summary>
        //public void STK_库存总账_Edit(ref DataType_会计期间 model)
        //{
        //    object m = model;
        //    ProcProxy.ExecuteNoQuery("P_STK_期末结账_Edit", ref m);
        //}
        public DataSet STK_库存总账_List(DataType_库存管理 model)
        {
            return ProcProxy.ExecuteDataSet("P_STK_库存总账_List", model);
        }
         #endregion
        #endregion

    }
}
