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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CARSINFO cARSINFO = new CARSINFO();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if(true)
            {
                CARSINFO cARSINFO = new CARSINFO();
                cARSINFO.CAR_NUMBER = textBoxcARnUMBER.Text;
                cARSINFO.MODEL = textBoxModel.Text;
                cARSINFO.OWNER = textBoxOwner.Text;
                cARSINFO.PRODUCTION_YEAR = Convert.ToDateTime(dateTimePicker1.Text);

                string url = @"http://localhost:53758/api/Car";
                string postData = JsonConvert.SerializeObject(cARSINFO);

                var res = Helper.CreateHttpPostRequest(url, postData);

                MessageBox.Show(res);
            }
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
          
            int ID = cARSINFO.ID;

            string url = @"http://localhost:53758/api/Car/" + ID;

            cARSINFO.CAR_NUMBER = textBoxcARnUMBER.Text;
            cARSINFO.OWNER = textBoxOwner.Text;
            cARSINFO.PRODUCTION_YEAR = DateTime.Parse(dateTimePicker1.Text);
            cARSINFO.MODEL = textBoxModel.Text;

            string putdata = JsonConvert.SerializeObject(cARSINFO);

            var putres = Helper.CreateHttpPutRequest(url, putdata);

            MessageBox.Show(putres);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 9)
                {
                    string carNumber = "YY-666-ZZ";

                    string url = @"http://localhost:53758/api/Car?carNumber=" + carNumber;

                    string res = Helper.Get(url);

                    cARSINFO = JsonConvert.DeserializeObject<CARSINFO>(res);

                    textBoxcARnUMBER.Text = cARSINFO.CAR_NUMBER;
                    textBoxModel.Text = cARSINFO.MODEL;
                    textBoxOwner.Text = cARSINFO.OWNER;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
