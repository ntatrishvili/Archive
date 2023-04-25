using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace OrdersApp
{
    class Program
    {
        static void Main(string[] args)
        {

            DbHelper.SendArc();
        }
    }
}
