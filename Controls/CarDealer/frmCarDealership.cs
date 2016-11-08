//Author:   Peter Eugene Mbanda
//Date:     3/11/2016
//Purpose:  Car dealership application

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using System.Windows.Forms;

namespace CarDealer
{
    public partial class frmCarDealership : Form
    {
        public frmCarDealership()
        {
            InitializeComponent();
        }
        //on form load uncheck the radio buttons
        private void frmCarDealership_Load(object sender, EventArgs e)
        {
            radBmw.Checked = false;
            radLexus.Checked = false;
            radMercedes.Checked = false;
        }

        //if the button is checked
        private void radLexus_CheckedChanged(object sender, EventArgs e)
        {
            //initialize the form compatible with the car make
            //and uncheck the current selection
            if (radLexus.Checked == true)
            {
                Form lexus = new frmLexus();
                lexus.ShowDialog();
                radLexus.Checked = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radMercedes_CheckedChanged(object sender, EventArgs e)
        {
            //initialize the form compatible with the car make
            //and uncheck the current selection
            if (radMercedes.Checked == true)
            {
                Form mercedes = new frmMercedes();
                mercedes.ShowDialog();
                radMercedes.Checked = false;
            }
        }

        private void radBmw_CheckedChanged(object sender, EventArgs e)
        {
            //initialize the form compatible with the car make
            //and uncheck the current selection
            if (radBmw.Checked == true)
            {
                Form bmw = new frmBMW();
                bmw.ShowDialog();
                radBmw.Checked = false;
            }
        }
    }
}
