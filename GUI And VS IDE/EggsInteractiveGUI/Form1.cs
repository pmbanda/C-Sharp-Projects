//Author:   Peter Eugene Mbanda
//Date:     1/14/2016
//Purpose:  Egg Calculator

using System;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //declare the class variables 
            int num1, num2, num3, num4, num5;

            //obtain the text input and convert to integer equivalent
            num1 = Convert.ToInt32(txtBox1.Text);
            num2 = Convert.ToInt32(txtBox2.Text);
            num3 = Convert.ToInt32(txtBox3.Text);
            num4 = Convert.ToInt32(txtBox4.Text);
            num5 = Convert.ToInt32(txtBox5.Text);

            int totalEggs = num1 + num2 + num3 + num4 + num5;//total eggs 
            int dozenEggs = totalEggs / 12;//number of dozens 
            int remainderEggs = totalEggs % 12;//remainder eggs 

            //display the amount 
            lblTotal.Text = string.Format("{0} eggs is {1} dozen with {2} left over ",totalEggs,dozenEggs,remainderEggs );
            lblTotal.Visible = true;//make label visible

            Console.ReadLine();
        }
    }
}
