//Author:   Peter Eugene Mbanda
//Date:     1/14/2016
//Purpose:  month application
using System;
using System.Windows.Forms;

namespace MonthNamesGUI
{
    public enum Month
    {
        //declare the enums
        JANUARY = 1, FEBRUARY, MARCH, APRIL, MAY, JUNE, JULY, AUGUST, SEPTEMBER, OCTOBER, NOVEMBER, DECEMBER
    }
    public partial class FormMonths : Form
    {
        public FormMonths()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtIntEntry.Text);//convert string entry to integer

            switch ((Month)num)
            {
                //use switch case to determine the month entered
                case Month.JANUARY:
                    lblDisplay.Text = Month.JANUARY.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.FEBRUARY:
                    lblDisplay.Text = Month.FEBRUARY.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.MARCH:
                    lblDisplay.Text = Month.MARCH.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.APRIL:
                    lblDisplay.Text = Month.APRIL.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.MAY:
                    lblDisplay.Text = Month.MAY.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.JUNE:
                    lblDisplay.Text = Month.JUNE.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.JULY:
                    lblDisplay.Text = Month.JULY.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.AUGUST:
                    lblDisplay.Text = Month.AUGUST.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.SEPTEMBER:
                    lblDisplay.Text = Month.SEPTEMBER.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.OCTOBER:
                    lblDisplay.Text = Month.OCTOBER.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.NOVEMBER:
                    lblDisplay.Text = Month.NOVEMBER.ToString();
                    lblDisplay.Visible = true;
                    break;
                case Month.DECEMBER:
                    lblDisplay.Text = Month.DECEMBER.ToString();
                    lblDisplay.Visible = true;
                    break;
                default:
                    //in case the range falls out of scope display default case
                    lblDisplay.Text = "Enter integer between 1 and 12 ";
                    break;
            }
        }
    }
}
