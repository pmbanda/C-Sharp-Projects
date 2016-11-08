namespace PayrollGUI
{
    partial class FormPayroll
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblFedTax = new System.Windows.Forms.Label();
            this.lblStateTax = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblCalcGross = new System.Windows.Forms.Label();
            this.lblCalcFed = new System.Windows.Forms.Label();
            this.lblCalcState = new System.Windows.Forms.Label();
            this.lblCalcNet = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(73, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(88, 13);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Payroll Calculator";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(38, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Name:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(13, 59);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(79, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Social Number:";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(13, 85);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(87, 13);
            this.lbl3.TabIndex = 3;
            this.lbl3.Text = "Hourly Pay Rate:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(13, 111);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(79, 13);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Hours Worked:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(129, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(170, 20);
            this.txtName.TabIndex = 5;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Location = new System.Drawing.Point(129, 82);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(73, 20);
            this.txtHourlyRate.TabIndex = 7;
            this.txtHourlyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(129, 108);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(73, 20);
            this.txtHoursWorked.TabIndex = 8;
            this.txtHoursWorked.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(13, 173);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(64, 13);
            this.lblGross.TabIndex = 9;
            this.lblGross.Text = "Gross Pay:  ";
            this.lblGross.Visible = false;
            // 
            // lblFedTax
            // 
            this.lblFedTax.AutoSize = true;
            this.lblFedTax.Location = new System.Drawing.Point(13, 199);
            this.lblFedTax.Name = "lblFedTax";
            this.lblFedTax.Size = new System.Drawing.Size(124, 13);
            this.lblFedTax.TabIndex = 10;
            this.lblFedTax.Text = "Federal withholding tax:  ";
            this.lblFedTax.Visible = false;
            // 
            // lblStateTax
            // 
            this.lblStateTax.AutoSize = true;
            this.lblStateTax.Location = new System.Drawing.Point(13, 225);
            this.lblStateTax.Name = "lblStateTax";
            this.lblStateTax.Size = new System.Drawing.Size(114, 13);
            this.lblStateTax.TabIndex = 11;
            this.lblStateTax.Text = "State withholding tax:  ";
            this.lblStateTax.Visible = false;
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Location = new System.Drawing.Point(13, 251);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(53, 13);
            this.lblNetPay.TabIndex = 12;
            this.lblNetPay.Text = "Net pay:  ";
            this.lblNetPay.Visible = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.AutoSize = true;
            this.btnCalculate.Location = new System.Drawing.Point(16, 137);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(93, 23);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate Salary";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblCalcGross
            // 
            this.lblCalcGross.AutoSize = true;
            this.lblCalcGross.Location = new System.Drawing.Point(167, 173);
            this.lblCalcGross.Name = "lblCalcGross";
            this.lblCalcGross.Size = new System.Drawing.Size(34, 13);
            this.lblCalcGross.TabIndex = 14;
            this.lblCalcGross.Text = "Gross";
            this.lblCalcGross.Visible = false;
            // 
            // lblCalcFed
            // 
            this.lblCalcFed.AutoSize = true;
            this.lblCalcFed.Location = new System.Drawing.Point(167, 199);
            this.lblCalcFed.Name = "lblCalcFed";
            this.lblCalcFed.Size = new System.Drawing.Size(25, 13);
            this.lblCalcFed.TabIndex = 15;
            this.lblCalcFed.Text = "Fed";
            this.lblCalcFed.Visible = false;
            // 
            // lblCalcState
            // 
            this.lblCalcState.AutoSize = true;
            this.lblCalcState.Location = new System.Drawing.Point(167, 225);
            this.lblCalcState.Name = "lblCalcState";
            this.lblCalcState.Size = new System.Drawing.Size(32, 13);
            this.lblCalcState.TabIndex = 16;
            this.lblCalcState.Text = "State";
            this.lblCalcState.Visible = false;
            // 
            // lblCalcNet
            // 
            this.lblCalcNet.AutoSize = true;
            this.lblCalcNet.Location = new System.Drawing.Point(167, 251);
            this.lblCalcNet.Name = "lblCalcNet";
            this.lblCalcNet.Size = new System.Drawing.Size(24, 13);
            this.lblCalcNet.TabIndex = 17;
            this.lblCalcNet.Text = "Net";
            this.lblCalcNet.Visible = false;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(129, 56);
            this.maskedTextBox1.Mask = "000-00-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(95, 20);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // FormPayroll
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 285);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblCalcNet);
            this.Controls.Add(this.lblCalcState);
            this.Controls.Add(this.lblCalcFed);
            this.Controls.Add(this.lblCalcGross);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblStateTax);
            this.Controls.Add(this.lblFedTax);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblHeading);
            this.Name = "FormPayroll";
            this.Text = "Payroll Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblFedTax;
        private System.Windows.Forms.Label lblStateTax;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblCalcGross;
        private System.Windows.Forms.Label lblCalcFed;
        private System.Windows.Forms.Label lblCalcState;
        private System.Windows.Forms.Label lblCalcNet;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}

