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
    public partial class Payment : Form
    {
        PaymentRequest request = new PaymentRequest();
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(PaymentRequest request)
        {
            this.request.AbonnentCode = request.AbonnentCode;
            this.request.CompanyName = request.CompanyName;
            this.request.Operation = request.Operation;
            this.request.TransactionID = request.TransactionID;
            InitializeComponent();
        }
        private void buttonPay_Click(object sender, EventArgs e)
        {
            using (PaymentServiceSoapClient client = new PaymentServiceSoapClient())
            {
                request.Amount =double.Parse(TextBoxAmount.Text);
                string hashString = string.Concat(request.AbonnentCode, request.CompanyName, request.Operation, request.TransactionID, request.Amount, Helper.key);
                request.HashCode = Helper.GetHashCode(hashString);


                PaymentResponse response = client.Payment(request);
                Error error = response.Error;

                if (error.errorCode==6)
                {
                    MessageBox.Show(string.Format("warmateba, {0} ", response.InternalID));
                }
                else
                {
                    MessageBox.Show(error.description);
                }
            }
        }
    }
}
