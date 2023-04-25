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

namespace RESTCklient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = string.Format("http://localhost:58180/Api/values?personalID={0}", textBox1.Text);
            string response = Helper.MakeGetRequest(url);
            Client client = JsonConvert.DeserializeObject<Client>(response);
            label1.Text = client.firstName;
            label2.Text = client.address;
             
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Client client = new Client();
            client.firstName = "emzari";
            string postdata = JsonConvert.SerializeObject(client);
            string result = Helper.MakePostRequest(@"http://localhost:58180/Api/values", postdata);
        }
    }
}
