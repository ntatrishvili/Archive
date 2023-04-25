using Rates.RateServiceReference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rates
{
    public static class Helper
    {
        public static DataTable GetRates(CurrencyRate[] rates)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Quantity");
            table.Columns.Add("Rate");
            table.Columns.Add("Name");
            table.Columns.Add("Diff");
            table.Columns.Add("Date");
            table.Columns.Add("Code");
            foreach (var item in rates)
            {
                table.Rows.Add(item.Quantity, item.Rate, item.Name, item.Diff, item.Date, item.Code);

            }
            return table;
        }
    }
}
