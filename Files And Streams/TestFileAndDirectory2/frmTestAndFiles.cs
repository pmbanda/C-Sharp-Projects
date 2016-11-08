//Author:   Peter Eugene Mbanda
//Date:     4/21/2016
//Purpose:  Determine files in a directory using the checked list box 
//          and display the files information


using System;
using System.IO;
using System.Windows.Forms;

namespace TestFileAndDirectory2
{
    public partial class frmTestAndFile : Form
    {
        public frmTestAndFile()
        {
            //directory name to be viewed
            string directoryName = @"H:\Java";
            //create an array to store the files
            string[] files;

            InitializeComponent();
            //obtain the files in the directory
            files = Directory.GetFiles(directoryName);

            //loop to deermine the files and its contents
            for (int i = 0; i < files.Length; i++)
            {
                //add the files to a checked list box based on the directory selection
                chkLstBoxDirectory.Items.Add(files[i]);
            }
        }

        private void frmTestAndFile_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //determine the item selected
            string item = chkLstBoxDirectory.SelectedItem.ToString();

            //assign the creation date and time to the label
            lblInformation.Text = item +
                " was created \n" + File.GetCreationTime(item);         
        }
    }
}
