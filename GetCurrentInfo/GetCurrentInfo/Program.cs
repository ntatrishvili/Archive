using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetCurrentInfo
{
    class Program
    {
        static void Main(string[] args)
        {
             public static string ConnectionString = @"Data Source=LAPTOP-QQDBCMF7\SQLEXPRESS;Initial Catalog=W3SCHOOL;Integrated Security = SSPI;";
        
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
