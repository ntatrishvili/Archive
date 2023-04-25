using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PayBoxForm.ServiceReference1;

namespace PayBoxForm
{
    public partial class PayBox : Form
    {
        public PayBox()
        {
            InitializeComponent();
        }

        private void PayBox_Load(object sender, EventArgs e)
        {
            buttonPay.Hide();
        }
        
        private void buttonNext_Click(object sender, EventArgs e)
        {
            
            using (PaymentServiceSoapClient client = new PaymentServiceSoapClient())
            {
                CheckDebtRequest request = new CheckDebtRequest();
                request.CompanyName = "biobio";
                request.AbonnentCode = TextBoxAbonentCode.Text;
                request.Operation = "check";
                string hashString = string.Concat(request.AbonnentCode, request.CompanyName, request.Operation, Helper.key);
                request.HashCode = Helper.GetHashCode(hashString);
                CheckDebtResponse response = client.CheckDebt(request);
                if (response.Error.errorCode == 0)
                {
                    labelInitials.Text = response.InitialParameters.Initials;
                    labelDebt.Text = response.InitialParameters.Debt.ToString();
                    buttonPay.Show();
                }
                else
                {  
                     MessageBox.Show(String.Format("error number: {0}, description: {1}", response.Error.errorCode.ToString(), response.Error.description));
                }

            }

        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            PaymentRequest request = new PaymentRequest();
            request.AbonnentCode = TextBoxAbonentCode.Text;
            request.CompanyName = "lolo";
            request.Operation = "payment";
            string hashString = string.Concat(request.AbonnentCode, request.CompanyName, request.Operation, Helper.key);
            request.HashCode = Helper.GetHashCode(hashString);
            var guid = Guid.NewGuid().ToString();
            request.TransactionID = guid;
            Payment payment = new Payment(request);
            payment.Show();
            this.Hide();
        }
    } 
}
