using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace OrdersApp
{
    public static class DbHelper
    {
        public static string ConnectionString = @"Data Source=LAPTOP-QQDBCMF7\SQLEXPRESS;Initial Catalog=W3SCHOOL;Integrated Security = SSPI;";
        public static void SendArc()
        {
            string commandText = "dbo.ARCHIVE_ORDERS";
            using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["nia"].ConnectionString))
            {
                using (var command = new SqlCommand())
                {
                    command.CommandText = commandText;
                    command.Connection = conn;
                    command.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
