//Author:   Peter Eugene Mbanda
//Date:     1/14/2016
//Purpose:  Payroll calculator

using System;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class FormPayroll : Form
    {
        public FormPayroll()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //define constants for federal and state rates 
            const double fedRate = 15 / 100.0;
            const double stateRate = 5 / 100.0;

            //define local variables
            double hourlyPayRate = Convert.ToDouble(txtHourlyRate.Text);
            double hoursWorked = Convert.ToDouble(txtHoursWorked.Text);

            //calulate gross pay federal and state tax 
            double grossPay = hourlyPayRate * hoursWorked;
            double federalTax = grossPay * fedRate;
            double stateTax = grossPay * stateRate;

            //calculate the net pay 
            double netPay = grossPay - (federalTax + stateTax);

            //make labels visible to display the results 
            lblCalcGross.Text = grossPay.ToString("C2");
            lblGross.Visible = true;
            lblCalcGross.Visible = true;
            //federal tax calculation
            lblCalcFed.Text = federalTax.ToString("C2");
            lblFedTax.Visible = true;
            lblCalcFed.Visible = true;
            //state tax calculation
            lblCalcState.Text = stateTax.ToString("C2");
            lblStateTax.Visible = true;
            lblCalcState.Visible = true;
            //net pay calculation
            lblCalcNet.Text = netPay.ToString("C2");
            lblNetPay.Visible = true;
            lblCalcNet.Visible = true;




        }
    }
}
