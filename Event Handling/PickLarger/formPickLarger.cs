// Author:      Peter Eugene Mbanda
// Date:        5/12/2016
// Purpose:          

using System;
using System.Windows.Forms;

namespace PickLarger
{
    public partial class formPickLarger : Form
    {
        // Create two array objects
        int[] array1 = new int[100];
        int[] array2 = new int[100];

        // local class variables
        int countCorrect = 0, countIncorrect = 0, totalInArray1, totalInArray2;

        public formPickLarger()
        {
            InitializeComponent();
        }
        private void formPickLarger_Load(object sender, EventArgs e)
        {
            PopulateArrays();// method to assign arrays 
            
            // event handler to listen to the events on click
            btn1.Click += new EventHandler(OnClick);
            btn2.Click += new EventHandler(OnClick);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Enable array buttons when the next is clicked
            btn1.Enabled = true;
            btn2.Enabled = true;

            // if user makes more than 100 guesses reset the array subscript to 0
            if((countIncorrect + countIncorrect) > 100 )
            {
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = 0; // reset subscripts to 0
                }
                for (int i = 0; i < array2.Length; i++)
                {
                    array2[i] = 0; // reset subscripts to 0
                }
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
        }
        private void OnClick(object sender, EventArgs e)
        {
            // Determine the object causing the event 
            string buttonClicked = sender.ToString();

            if(buttonClicked.Equals("System.Windows.Forms.Button, Text: 1"))
            {
                if (totalInArray1 > totalInArray2)
                {
                    // Determine if the array in button 1 is greater than button 2 array
                    lblGuessResult.Visible = true;
                    lblGuessResult.Text = "Correct Guess";
                    ++countCorrect;
                }
                else
                {
                    lblGuessResult.Visible = true;
                    lblGuessResult.Text = "Wrong Guess";
                    ++countIncorrect;
                }

                // Display values of the arrays
                lblResult.Visible = true;
                lblResult.Text = "Array1: " + totalInArray1 + "  Array2: " + totalInArray2;
                
            }
            else if(buttonClicked.Equals("System.Windows.Forms.Button, Text: 2"))
            {
                if (totalInArray2 > totalInArray1)
                {
                    // Determine if the array in button 2 is greater than button 1 array
                    lblGuessResult.Visible = true;
                    lblGuessResult.Text = "Correct Guess";
                    ++countCorrect;
                }
                else
                {
                    lblGuessResult.Visible = true;
                    lblGuessResult.Text = "Wrong Guess";
                    ++countIncorrect;
                }

                // Display values of the arrays
                lblResult.Visible = true;
                lblResult.Text = "Array 1: " + totalInArray1 + "  Array2: " + totalInArray2;
                
            }
            // Display values of the correct and incorrect guesses
            lblGuessValues.Visible = true;
            lblGuessValues.Text = "Correct Guess: " + countCorrect + " (vs) Incorrect Guess " + countIncorrect;

            btn1.Enabled = false;
            btn2.Enabled = false;
            PopulateArrays();// invoke method to populate the arrays
        }
        private void PopulateArrays()
        {
            // Random number generator
            Random r = new Random();
            int value;
            // randomly populate the array with 100 numbers
            for (int i = 0; i < array1.Length; i++)
            {
                value = r.Next(1, 1000);
                totalInArray1 = value;
            }

            // randomly populate the array with 100 numbers
            for (int i = 0; i < array2.Length; i++)
            {
                value = r.Next(1, 1000);
                totalInArray2 = value;
            }
        }
    }
}
