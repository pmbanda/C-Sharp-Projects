using System;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            //Declare the minimum and maximum numbers to be 
            //generated excluding the max value 
            int min = 1;
            int max = 11;

            Random randomGenerator = new Random();//instantiate the random class

            int randomNumber = randomGenerator.Next(min, max);//minimum inclusive and maximum exclusive


            if (randomNumber == Convert.ToInt32(txtGuess.Text))
                lblDisplay.Text = "Guess is Correct";
            else if (randomNumber > Convert.ToInt32(txtGuess.Text))
                lblDisplay.Text = "Guess was too low ";
            else
                lblDisplay.Text = "Guess was too high ";

            lblComp.Text = "Computer Generated " + randomNumber;
            lblComp.Visible = true;
            lblDisplay.Visible = true;


            
        }
    }
}
