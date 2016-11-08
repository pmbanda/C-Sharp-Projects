//Author:   Peter Eugene Mbanda
//Date:     3/11/2016
//Purpose:  Movie price application

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using System.Windows.Forms;

namespace MyFlix
{
    public partial class frmMovies : Form
    {
        //define the constant price for price per download
        const double PRICE_PER_DOWNLOAD = 1.99;

        public frmMovies()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //make the display label invinsible when the form loads
            lblDisplay.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //local variable
            int selections;

            //total number of the items selected
            selections = lstBoxMovies.SelectedItems.Count;

            //display the total price in the selection
            lblDisplay.Text = "Total for selection " + (selections * PRICE_PER_DOWNLOAD).ToString("C");
            lblDisplay.Visible = true;
        }
    }
}
