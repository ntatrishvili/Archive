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
    public partial class UpdateClient : Form
    {
        ServiceReference1.ServiceCESKOClient client;
        public UpdateClient()
        {
            InitializeComponent();
            client = new ServiceReference1.ServiceCESKOClient();

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            ServiceReference1.Client clients = new ServiceReference1.Client();
            clients.FirstName = textBoxName.Text;
            clients.Address = textBoxAddress.Text;
            clients.BirthDate = dateTimePicker1.Value;
            clients.LastName = textBoxSurname.Text;
            clients.PersonalID = textBoxID.Text;
            //client.pictureBase64 = pictureBox1.Image;
            client.ClientUpdate(clients);

        }
    }
}
