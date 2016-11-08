//Author:   Peter Eugene Mbanda
//Date:     3/11/2016
//Purpose:  Form Color changing application

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FiveColors2
{
    public partial class frmRadioColors : Form
    {
        public frmRadioColors()
        {
            InitializeComponent();
            
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            //assign the buton text color to the form when button is clicked
            if (radRed.Checked)
                this.BackColor = Color.Red;
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            //assign the buton text color to the form when button is clicked
            if (radGreen.Checked)
                this.BackColor = Color.Green;
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            //assign the buton text color to the form when button is clicked
            if (radBlue.Checked)
                this.BackColor = Color.Blue;
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            //assign the buton text color to the form when button is clicked
            if (radBlack.Checked)
                this.BackColor = Color.Black;
        }

        private void radViolet_CheckedChanged(object sender, EventArgs e)
        {
            //assign the buton text color to the form when button is clicked
            if (radViolet.Checked)
                this.BackColor = Color.Violet;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //assign the buton text color to the form when button is clicked
            radRed.Checked = false;
        }
    }
}
