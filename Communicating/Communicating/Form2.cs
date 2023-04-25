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
    public partial class Form2 : Form
    {
        public delegate void Message(string str);
        public event Message OnMessage;
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1Click(object sender, EventArgs e)
        {
            progressBar1.Increment(10);
            switch (radioButton1.Checked)
            {
                case (true || false): MessageBox.Show("a");
                    int a = 0;
                    Convert.ToString()
            }
        }

    }
}
