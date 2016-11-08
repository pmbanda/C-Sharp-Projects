//Author:   Peter Eugene Mbanda
//Date:     1/13/2016
//purpose:  Car rental application

using System;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class carRentalForm : Form
    {
        public carRentalForm()
        {
            InitializeComponent();
        }

        private void displayTotalLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //local variables declaration
            const double feeRate = 20;
            const double mileRate = 0.25;

            //convert the string values to the equivalent integer and double for miles
            int days = Convert.ToInt32(rentDaysTextBox.Text);
            double miles = Convert.ToDouble(milesTextBox.Text);

            //calculate total price (days * rate) + (miles * miles rate )
            double total = (days * feeRate) + (miles * mileRate);

            //disaplay the result to the final label
            displayTotalLabel.Text = total.ToString("C2");

            displayTotalLabel.Visible = true;//set the label as visible
        }
    }
}
