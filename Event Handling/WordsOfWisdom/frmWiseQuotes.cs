// Author:   Peter Eugene Mbanda
// Date:     5/4/2016
// Purpose:  Quotes application differ depending on the events initiated


using System;
using System.Drawing;
using System.Windows.Forms;

namespace WordsOfWisdom
{
    public partial class frmWiseQuotes : Form
    {
        public frmWiseQuotes()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmWiseQuotes_Load(object sender, EventArgs e)
        {
            // Black color on the form and the labels
            // during form load
            this.BackColor = Color.Black;
            lblQuoteBob.BackColor = Color.Black;
            lblTupacQuote.BackColor = Color.Black;
            lblBruceLee.BackColor = Color.Black;
            lblrodneyQuote.BackColor = Color.Black;

        }

        private void frmWiseQuotes_MouseHover(object sender, EventArgs e)
        {
            

        }

        private void lblQuoteBob_Click(object sender, EventArgs e)
        {

        }

        private void lblQuoteBob_MouseHover(object sender, EventArgs e)
        {
            // Set background color white on mouse hover event
            lblQuoteBob.BackColor = Color.White;
        }

        private void lblTupacQuote_MouseHover(object sender, EventArgs e)
        {
            // Set background color white on mouse hover event
            lblTupacQuote.BackColor = Color.White;
        }

        private void lblBruceLee_MouseHover(object sender, EventArgs e)
        {
            // Set background color white on mouse hover event
            lblBruceLee.BackColor = Color.White;
        }

        private void lblrodneyQuote_MouseHover(object sender, EventArgs e)
        {
            // Set background color white on mouse hover event
            lblrodneyQuote.BackColor = Color.White;
        }
    }
}
