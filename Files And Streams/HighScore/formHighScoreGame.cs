//Author:   Peter Eugene Mbanda
//Date:     5/26/2016
//Purpose:  Guessing Game

using System;
using System.IO;
using System.Windows.Forms;

namespace HighScore
{
    public partial class frmHighScoreGame : Form
    {
        //file name
        const string FILENAME = @"H:\C#\Chapter14\HighScore\bin\Debug\Score.txt";
        string data;
        int number;
        string value;
        int score = 0;
        int count = 0;

        //computers random guess
        Random randomNumber = new Random();

        //stream to read the file and contents
        static FileStream myFile = new FileStream(FILENAME,FileMode.Open, FileAccess.Read);
        StreamReader inFile = new StreamReader(myFile);

        public frmHighScoreGame()
        {
            InitializeComponent();
        }   

        private void frmHighScoreGame_Load(object sender, EventArgs e)
        {
            //read file contents
            data = inFile.ReadLine();

            //determine of the end of the file is reached
            while(inFile.Peek() > -1)
            {
                data = inFile.ReadLine();
            }

            //display the last score on the form
            lblScore.Text = data;
            lblScore.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //assign the users score
            lblNewScore.Text = score.ToString();
            lblNewScore.Visible = true;
            number = randomNumber.Next(65, 68);

            //convert the value to a character
            value = Convert.ToChar(number).ToString();

            //display the results 
            lblResult.Text = "You entered " + txtEntry.Text +
                "\nthe computer selected " + value;
            lblResult.Visible = true;

            //if player guesses as the computer give a score
            //of 5 each time or else give 0
            if (value.Equals(txtEntry.Text))
                    score += 5;
            else
                score += 0;

            lblNewScore.Text = score.ToString();

            //save the new high score on file if the user beats the previous one
            if( (Convert.ToInt32(score) > Convert.ToInt32(data)) && (count >= 9))
            {
                inFile.Close();
                myFile.Close();

                string fileName = @"H:\C#\Chapter14\HighScore\bin\Debug\Score.txt";

                //open file stream to write data to the file if score is greater than previous
                FileStream file = new FileStream(fileName, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(file);

                //write score to the file
                writer.WriteLine(Convert.ToInt32(score));
                writer.Close();
                file.Close();
            }

            //if player plays 10 times disable the button 
            if (count >= 9)
            {
                btnPlay.Enabled = false;
                txtEntry.Enabled = false;
            }

            //increment counter
            ++count;
        }
    }
}
