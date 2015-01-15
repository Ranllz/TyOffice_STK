using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


namespace DN_GBJY_WS
{
    public static class ExtendMethods
    {
        public static void AddInOutParameter(this SqlDatabase db, DbCommand command, string name, SqlDbType dbType, int size)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, DBNull.Value);
        }

        public static void AddInOutParameter(this SqlDatabase db, DbCommand command, string name, SqlDbType dbType, int size, object value)
        {
            db.AddParameter(command, name, dbType, size, ParameterDirection.InputOutput, true, 0, 0, String.Empty, DataRowVersion.Default, value);
        }

    }

    public class DN_DB_Tools
    {


    }
}