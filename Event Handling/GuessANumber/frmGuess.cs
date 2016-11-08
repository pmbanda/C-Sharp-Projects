// Author:      Peter Eugene Mbanda
// Date:        5/6/2016
// Purpose:     Guessing game application

using System;
using System.Collections;
using System.Windows.Forms;

namespace GuessANumber
{
    public partial class frmGuess : Form
    {
        // Initialize a ramdom object
        static Random r = new Random();
        int winningButton;

        public frmGuess()
        {
            InitializeComponent();
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void frmGuess_Load(object sender, EventArgs e)
        {
            // Generate a random number between 1 and 6 exclusive
            winningButton = r.Next(1, 6);
        }

        private void radOne_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if the radio button selected matches the computers guess
            lblResult.Visible = true;
            if (Convert.ToInt32(radOne.Text) == winningButton)
                lblResult.Text = "Correct Guess";
            else
                lblResult.Text = "Wrong Guess";
;        }

        private void radTwo_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if the radio button selected matches the computers guess
            lblResult.Visible = true;
            if (Convert.ToInt32(radTwo.Text) == winningButton)
                lblResult.Text = "Correct Guess";
            else
                lblResult.Text = "Wrong Guess";
        }

        private void radThree_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if the radio button selected matches the computers guess
            lblResult.Visible = true;
            if (Convert.ToInt32(radThree.Text) == winningButton)
                lblResult.Text = "Correct Guess";
            else
                lblResult.Text = "Wrong Guess";
        }

        private void radFour_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if the radio button selected matches the computers guess
            lblResult.Visible = true;
            if (Convert.ToInt32(radFour.Text) == winningButton)
                lblResult.Text = "Correct Guess";
            else
                lblResult.Text = "Wrong Guess";
        }

        private void radOne_Click(object sender, EventArgs e)
        {
            
            
           
            
            

        }

        private void radFive_CheckedChanged(object sender, EventArgs e)
        {
            // Determine if the radio button selected matches the computers guess
            lblResult.Visible = true;
            if (Convert.ToInt32(radFive.Text) == winningButton)
                lblResult.Text = "Correct Guess";
            else
                lblResult.Text = "Wrong Guess";
        }

        private void lblHint_MouseHover(object sender, EventArgs e)
        {
            // Create array list to hold the numbers involved
            ArrayList nums = new ArrayList{ 1, 2, 3, 4, 5 };

            // Remove the computer choice from the arraylist 
            nums.Remove(winningButton);

            foreach (var item in nums)
            {
                // display the output on the hint
                lblHint.Text = "Radio button " + item + " is incorrect ";
            }
             
        }
    }
}
