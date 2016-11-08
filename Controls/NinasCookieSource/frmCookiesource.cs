//Author:   Peter Eugene Mbanda
//Date:     3/11/2016
//Purpose:  Cookie application to determine the price based on the cookie

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using System.Windows.Forms;

namespace NinasCookieSource
{
    public partial class frmCookiesource : Form
    {
        //constants for the dozen values
        const int DOZEN = 12;
        const int HALF_DOZEN = (12 / 2);
        const int DOUBLE = (12 * 2);
        const int TRIPLE = (12 * 3);
        const int DAYS_TO_ADD = 3;

        //prices of cookies
        const double OATMEAL = 1.99;
        const double PEANUT_BUTTER = 2.99;
        const double OREO = 3.99;

        //global variables
        string cookieType = "";
        string dozenType = "";
       
        public frmCookiesource()
        {
            InitializeComponent();
        }

        private void frmCookie_Load(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //initialize the price to 0
            double price = 0;

            //determine the checked item and assign the price
            if (radOatmeal.Checked == true)
            {
                price = OATMEAL;
                cookieType = radOatmeal.Text;
            }
            //determine the checked item and assign the price
            else if (radPeanutButter.Checked == true)
            {
                price = PEANUT_BUTTER;
                cookieType = radPeanutButter.Text;
            }
            //determine the checked item and assign the price
            else if (radOreo.Checked == true)
            {
                price = OREO;
                cookieType = radOreo.Text;
            }
            //determine the checked item and multiply by the dozen category selected
            if (radDozen.Checked == true)
            {
                price *= DOZEN;
                dozenType = radDozen.Text;
            }
            //determine the checked item and multiply by the dozen category selected
            else if (radHalfDozen.Checked == true)
            {
                price *= HALF_DOZEN;
                dozenType = radHalfDozen.Text;
            }
            //determine the checked item and multiply by the dozen category selected
            else if (radTwoDozen.Checked == true)
            {
                price *= DOUBLE;
                dozenType = radTwoDozen.Text;
            }
            //determine the checked item and multiply by the dozen category selected
            else if (radThreeDozen.Checked == true)
            {
                price *= TRIPLE;
                dozenType = radThreeDozen.Text;
            }

            //assign current date as the minimum date
            calMyCalendar.MinDate = calMyCalendar.TodayDate;

            //display the selected options and the shipping date
            lblPrice.Text = dozenType + " " + cookieType + " Cost: " + price.ToString("C");
            lblShipping.Text = "Estimated Delivery Date: " + 
                calMyCalendar.SelectionStart.AddDays(DAYS_TO_ADD).ToShortDateString();
            //make the labels for display visible
            lblPrice.Visible = true;
            lblShipping.Visible = true;
        }
 

        private void grpDozenSelection_Enter(object sender, EventArgs e)
        {
            
           
        }

        private void grpCookieType_Enter(object sender, EventArgs e)
        {
            
        }
    }
}
