using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Communicating
{
    public partial class Form1 : Form
    {

        private Form2 form2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "This is default text.\nTo change it, open editor.";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            form2.Show();
            //form2.btn1Click+=(s1,e1) => label1.Text = e1
        }

        private void TxtMessage(string str)
        {
            this.label1.Text = str;
        }
    }
}
