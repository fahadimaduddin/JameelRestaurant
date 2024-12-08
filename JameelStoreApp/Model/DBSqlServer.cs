using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace JameelStoreApp.Model
{
    public class DBSqlServer
    {
        // ExecuteReader, ExecuteScalar and ExecuteNoQuery
        private string cs;
        public DBSqlServer(string cs)
        {
            this.cs = cs;
        }
        public object getScalarValue(string storedProceName)
        {
            object value = null;
            using (SqlConnection con = new SqlConnection(cs))
            {
                using (SqlCommand cmd = new SqlCommand(storedProceName, con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    value = cmd.ExecuteScalar();
                }
            }
            return value;
        }
    }
}
