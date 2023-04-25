using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rates.RateServiceReference;

namespace Rates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (ServiceSoapClient client = new ServiceSoapClient())
            {
                CurrencyRate[] rates = client.GetCurrentRates("USD,EUR,GBP,GEL");
                //int y = 50;
                //foreach (var item in rates)
                //{
                //    Label label = new Label()
                //    {
                //        Text = item.Quantity.ToString() + " - " + item.Code.ToString() + "(" + item.Name.ToString() + ") - " + item.Rate + " (Diff:" + item.Diff + ")",
                //        Location = new Point(20, y),
                //        Width = 800
                //    };
                //    this.Controls.Add(label);
                //    y += 50;
                //}
                dataGridView1.DataSource = Helper.GetRates(rates);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
