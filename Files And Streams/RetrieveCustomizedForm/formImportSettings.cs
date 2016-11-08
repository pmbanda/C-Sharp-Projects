//Author:   Peter Eugene Mbanda
//Date:     4/27/2016
//Purpose:  Read file contents containing the forms attributes 

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace RetrieveCustomizedForm
{
    public partial class frmImportSettings : Form
    {
        //file name
        static string fileName = @"H:\C#\Chapter14\CustomizeAForm\bin\Debug\FormProperties.txt";
        //class variables
        string color, size, title, width, height;
        const char DELIM = ',';

        //file stream and stream reader to read the files
        static FileStream file = new FileStream(fileName,FileMode.Open, FileAccess.Read);
        StreamReader reader = new StreamReader(file);

        public frmImportSettings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRetrieveSettings_Click(object sender, EventArgs e)
        {
            //obtain the contents as an array
            string values = reader.ReadLine();
            string[] contents;
           
            //split the values on the comma separated file
            contents = values.Split(DELIM);

            //separate the arrays in their individual indices
            color = contents[0];
            size = contents[1];
            title = contents[2];
            width = contents[3];
            height = contents[4];

            //assign the values to the label
            lblColor.Text = "Color: " + color;
            lblColor.Visible = true;
            lblSize.Text = "Size: " + size;
            lblSize.Visible = true;
            lblTitle.Text = "Title: " + title;
            lblTitle.Visible = true;
            lblWidth.Text = "Width: " + width;
            lblWidth.Visible = true;
            lblHeight.Text = "Height: " + height;
            lblHeight.Visible = true;

            //assign the form background color 
            //width and the heights attributes
            this.BackColor = Color.FromName(color);
            this.Width = Convert.ToInt32(width);
            this.Height = Convert.ToInt32(height);

            //disable the button
            btnRetrieveSettings.Enabled = false;
        }
    }
}
