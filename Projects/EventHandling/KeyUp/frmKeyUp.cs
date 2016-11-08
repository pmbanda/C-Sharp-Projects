using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyUp
{
    public partial class frmKeyUp : Form
    {
        public frmKeyUp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label1.Visible = true;
            label1.Text += "\n";
            label1.Text += "Key Code " + e.KeyCode;
            label1.Text += "\nAlt " + e.Alt;
            label1.Text += "\nShift " + e.Shift;
            label1.Text += "\nControl " + e.Control;
            label1.Text += "\nKey Data " + e.KeyData;
            label1.Text += "\nKey Value " + e.KeyValue;

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            
            label1.Text = "You clicked a letter button ";
        }
    }
}
