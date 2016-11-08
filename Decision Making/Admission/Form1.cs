//Author:   Peter Eugene Mbanda
//Date:     1/19/2016
//Purpose:  College Admission application
using System;
using System.Windows.Forms;

namespace Admission
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //declare the local variables 
            //obtain the gpa and convert it to a double equivalent
            double gPA = Double.Parse(txtGPA.Text);
            //obtain the score and convert to an integer equivalent 
            int score = (int)Double.Parse(txtScore.Text);

            //if gpa is greater than 3.0 and score >= 60 display accept
            if (gPA >= 3.0 && score >= 60)
                lblResponse.Text = "Accept";
            //if gpa is less than 3.0 and score >= 80 display accept
            else if (gPA < 3.0 && score >= 80)
                lblResponse.Text = "Accept";
            //if the conditions do not match display reject
            else
                lblResponse.Text = "Reject";

            lblResponse.Visible = true;//make the label visible
        }
    }
}
