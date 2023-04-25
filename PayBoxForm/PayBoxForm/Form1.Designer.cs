namespace PayBoxForm
{
    partial class PayBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxAbonentCode = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelInitials = new System.Windows.Forms.Label();
            this.labelDebt = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxAbonentCode
            // 
            this.TextBoxAbonentCode.Location = new System.Drawing.Point(169, 41);
            this.TextBoxAbonentCode.Name = "TextBoxAbonentCode";
            this.TextBoxAbonentCode.Size = new System.Drawing.Size(163, 20);
            this.TextBoxAbonentCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "აბონენტის კოდი:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ინიციალები:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "დავალიანება:";
            // 
            // labelInitials
            // 
            this.labelInitials.AutoSize = true;
            this.labelInitials.Location = new System.Drawing.Point(166, 136);
            this.labelInitials.Name = "labelInitials";
            this.labelInitials.Size = new System.Drawing.Size(0, 13);
            this.labelInitials.TabIndex = 5;
            // 
            // labelDebt
            // 
            this.labelDebt.AutoSize = true;
            this.labelDebt.Location = new System.Drawing.Point(166, 188);
            this.labelDebt.Name = "labelDebt";
            this.labelDebt.Size = new System.Drawing.Size(0, 13);
            this.labelDebt.TabIndex = 6;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(125, 80);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(64, 35);
            this.buttonNext.TabIndex = 7;
            this.buttonNext.Text = "შემდეგ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(257, 224);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(75, 40);
            this.buttonPay.TabIndex = 8;
            this.buttonPay.Text = "გადახდა";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // PayBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 296);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelDebt);
            this.Controls.Add(this.labelInitials);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxAbonentCode);
            this.Name = "PayBox";
            this.Load += new System.EventHandler(this.PayBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox TextBoxAbonentCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelInitials;
        private System.Windows.Forms.Label labelDebt;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPay;
    }
}

