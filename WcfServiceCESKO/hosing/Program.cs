using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace hosing
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WcfServiceCESKO.Service1));
            host.Open();
            Console.WriteLine("Service Hosted Sucessfully");
            Console.Read();
        }
    }
}
