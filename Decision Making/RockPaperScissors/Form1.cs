//Author:   Peter Eugene Mbanda
//Date:     1/19/2016
//Purpose:  rock Paper Scissors application
using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
    enum Rps
    {
        //create enum for constants 
        ROCK = 1, PAPER, SCISSORS
    }
    public partial class myForm : Form
    {
        public myForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //initialize the labels to a null value string
            lblResult.Text = "";
            lblComp.Text = "";
            lblUser.Text = "";

            //Declare the minimum and maximum numbers to be 
            //generated excluding the max value 
            int min = 1;
            int max = 4;

            Random randomGenerator = new Random();//instantiate the random class

            int randomNumber = randomGenerator.Next(min, max);//minimum inclusive and maximum exclusive

            switch(randomNumber)
            {
                //determine the computer decision based on the random number
                case 1:
                    lblComp.Text = "Computer chose " + Rps.ROCK.ToString();
                    lblComp.Visible = true;
                    break;
                case 2:
                    lblComp.Text = "Computer chose " + Rps.PAPER.ToString();
                    lblComp.Visible = true;
                    break;
                case 3:
                    lblComp.Text = "Computer chose " + Rps.SCISSORS.ToString();
                    lblComp.Visible = true;
                    break;
            }

            //display to the user the selection they made 
            if (txtEntry.Text == "r")
            {
                lblUser.Text = "You chose ROCK ";
                lblUser.Visible = true;
            }
            else if (txtEntry.Text == "p")
            {
                lblUser.Text = "You chose PAPER ";
                lblUser.Visible = true;
            }
            else if (txtEntry.Text == "s")
            {
                lblUser.Text = "You chose SCISSORS ";
                lblUser.Visible = true;
            }

            //if the user select the same decision as the computer display a tie
            if (txtEntry.Text.Equals("r") && randomNumber == (int)Rps.ROCK
                || (txtEntry.Text.Equals("p") && randomNumber == (int)Rps.PAPER) 
                || (txtEntry.Text.Equals("s") && randomNumber == (int)Rps.SCISSORS))
            {
                lblResult.Text = "There is a TIE ";
                lblResult.Visible = true;
            }
            //else rock beats scissors and whoever choses wins
            else if (txtEntry.Text.Equals("r") && randomNumber == (int)Rps.SCISSORS)
            {
                lblResult.Text = "ROCK beats SCISSORS ";
                lblResult.Visible = true;
            }
            else if (txtEntry.Text.Equals("s") && randomNumber == (int)Rps.ROCK)
            {
                lblResult.Text = "ROCK beats SCISSORS ";
                lblResult.Visible = true;
            }
            //else scissors beats paper and whoever choses wins
            else if (txtEntry.Text.Equals("s") && randomNumber == (int)Rps.PAPER)
            {
                lblResult.Text = "SCISSORS beats PAPER ";
                lblResult.Visible = true;
            }
            else if (txtEntry.Text.Equals("p") && randomNumber == (int)Rps.SCISSORS)
            {
                lblResult.Text = "SCISSORS beats PAPER ";
                lblResult.Visible = true;
            }
            //else paper beats rock and whoever choses wins
            else if (txtEntry.Text.Equals("p") && randomNumber == (int)Rps.ROCK)
            {
                lblResult.Text = "PAPER beats ROCK ";
                lblResult.Visible = true;
            }
            else if (txtEntry.Text.Equals("r") && randomNumber == (int)Rps.PAPER)
            {
                lblResult.Text = "PAPER beats ROCK ";
                lblResult.Visible = true;
            }
           
        }
    }
}
