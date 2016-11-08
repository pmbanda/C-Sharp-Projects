//Author:   Peter Eugene Mbanda
//Date:     3/11/2016
//Purpose:  Font family and size application 

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

namespace FontSelector
{
    public partial class frmFontSelector : Form
    {
        public frmFontSelector()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //select the item on the list if the user does not make a selection
            lstFontNames.SelectedIndex = 0;
            lstFontSize.SelectedIndex = 0;
            //make the display label invinsible on the form load
            lblDisplay.Visible = false;
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //determine the font type selected and the font sizes on the list box
            string fontType = lstFontNames.SelectedItem.ToString(); 
            int fontSize = Convert.ToInt32(lstFontSize.SelectedItem);

            //greeting to be displayed on the label 
            string greeting = "Hello";
            
            lblDisplay.Text = greeting;
            lblDisplay.Font = new Font(fontType,fontSize);//assign the font size and the font name 
            lblDisplay.Visible = true;//make the display label visible
        }
    }
}
