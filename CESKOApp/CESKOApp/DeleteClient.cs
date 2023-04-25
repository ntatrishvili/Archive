using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CESKOApp
{
    public partial class DeleteClient : Form
    {
        ServiceReference1.ServiceCESKOClient client;

        public DeleteClient()
        {
            InitializeComponent();
            client = new ServiceReference1.ServiceCESKOClient();

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            client.ClientDelete(textBox1.Text);
        }
    }
}
