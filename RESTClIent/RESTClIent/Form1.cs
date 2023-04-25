using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace RESTClIent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = string.Format("http://localhost:58180/Api/values?personalID={0}", textBox1.Text);

            string response = Helper.Get(url);
            var clientResponse = JsonConvert.DeserializeObject<client>(response);
        }
    }
}
