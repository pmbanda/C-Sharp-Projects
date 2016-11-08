//Author:   Peter Eugene Mbanda
//Date:     4/25/2016
//Purpose:  Determine the form particulars and write to the file

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CustomizeAForm
{
    public partial class frm : Form
    {
        //define global variables
        string colorString = "";
        string sizeString = "";
        string titleString = "";
        const string DELIM = ",";
        const string FILENAME = @"FormProperties.txt";

        //create a file to write all the form description and write to file using the writer
        static FileStream file = new FileStream(FILENAME, FileMode.Create, FileAccess.Write);
        StreamWriter outFile = new StreamWriter(file);

        public frm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //concatenate the text values of the label to display the title
            lblTitleSelected.Text = colorString + " " + sizeString;
            lblTitleSelected.Visible = true;
            titleString = colorString + " " + sizeString ; 

            //save contents to the file
            outFile.WriteLine(colorString + DELIM + sizeString + DELIM + titleString + DELIM
                + this.Width + DELIM + this.Height);

            //disable the button after saving to the file
            btnSubmit.Enabled = false;

        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        { 
            //determime if the green radio button is checked
            if (radGreen.Checked == true)
            {
                this.BackColor = Color.Green;
                colorString = radGreen.Text.ToString();
            }
        }

        private void grpColors_Enter(object sender, EventArgs e)
        {



        }

        private void grpSize_Enter(object sender, EventArgs e)
        {




        }
        private void frm_Load(object sender, EventArgs e)
        {
            
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            //determime if the red radio button is checked
            if (radRed.Checked == true)
            {
                this.BackColor = Color.Red;
                colorString = radRed.Text.ToString();
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            //determime if the blue radio button is checked
            if (radBlue.Checked == true)
            {
                this.BackColor = Color.Blue;
                colorString = radBlue.Text.ToString();
            }
        }

        private void radSmall_CheckedChanged(object sender, EventArgs e)
        {
            //determime if the small size radio button is checked
            if (radSmall.Checked == true)
            {
                this.Height = 300;
                this.Width = 300;
                sizeString = radSmall.Text.ToString();
            }
        }

        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            //determime if the normal size radio button is checked
            if (radNormal.Checked == true)
            {
                this.Height = 315;
                this.Width = 400;
                sizeString = radNormal.Text.ToString();
            }
        }

        private void radLarge_CheckedChanged(object sender, EventArgs e)
        {
            //determime if the large size radio button is checked
            if (radLarge.Checked == true)
            {
                this.Height = 700;
                this.Width = 700;
                sizeString = radLarge.Text.ToString();
            }
        }
    }

}
