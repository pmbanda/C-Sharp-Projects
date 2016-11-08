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

namespace FiveColors
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }
        //on click button changes the color equivalent to the button label color
        private void btnRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        //on click button changes the color equivalent to the button label color
        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
        //on click button changes the color equivalent to the button label color
        private void btnBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
        //on click button changes the color equivalent to the button label color
        private void btnViolet_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Violet;
        }
        //on click button changes the color equivalent to the button label color
        private void btnOrange_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }
    }
}
