using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.button1.Location = new System.Drawing.Point(77, 58);
            this.button1.Name = "Button2";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Button";
            this.button1.UseVisualStyleBackColor = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
