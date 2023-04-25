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
    public partial class AddClient : Form
    {
        Bitmap image;
        string Base64Image;
        ServiceReference1.ServiceCESKOClient client;
        public AddClient()
        {
            InitializeComponent();
            client = new ServiceReference1.ServiceCESKOClient();
        }
        

        private void AddClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ServiceReference1.Client clients = new ServiceReference1.Client();
            clients.FirstName = textBoxName.Text;
            clients.Address = textBoxAddress.Text;
            clients.BirthDate =dateTimePicker1.Value;
            clients.LastName = textBoxSurname.Text;
            clients.PersonalID = textBoxID.Text;
            clients.PictureBase64 = Base64Image;
            client.ClientRegistration(clients);

        }

        private void buttonPicture_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(.jpg)|.jpg| PNG files(.png)|.png| All Files(.)|*.*";

                dialog.CheckFileExists = true;
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    image = new Bitmap(dialog.FileName);

                    byte[] byteArray = System.IO.File.ReadAllBytes(dialog.FileName);
                    Base64Image = Convert.ToBase64String(byteArray);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
