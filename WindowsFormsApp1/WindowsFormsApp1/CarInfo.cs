using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public  class CARSINFO
    {
        public int ID { get; set;}
        public string CAR_NUMBER { get; set; }
        public string MODEL { get; set; }
        public Nullable<System.DateTime> PRODUCTION_YEAR { get; set; }
        public string OWNER { get; set; }
    }
}
