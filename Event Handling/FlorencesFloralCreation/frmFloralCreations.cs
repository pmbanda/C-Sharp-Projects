// Autrhor:     Peter Eugene Mbanda
// Date:        5/10/2016
// Purpose:     Folower delivery based on occassion application.

using System;
using System.Windows.Forms;

namespace FlorencesFloralCreation
{
    public partial class frmFloralCreations : Form
    {
        public frmFloralCreations()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the list box every time the method is invoked
            lstFlowers.Items.Clear();
            // Determine the selected item from the occassion list box 
            string occassion = (string)lstOccassion.SelectedItem;

            if(occassion.Equals("Get Well"))
            {
                // Populate the array in the new list box
                string[] flower = { "Geranium ", "Poppy", "Orchid " };
                lstFlowers.Items.AddRange(flower);
                lstFlowers.Visible = true;
                lblCongrats.Visible = true;
                lblCongrats.Text = "Good selection of " + occassion + " flowers";
            }
            else if (occassion.Equals("Graduation"))
            {
                // Populate the array in the new list box
                string[] flower = { "Lily ", "Lavender", "Lotus ", "Rose" };
                lstFlowers.Items.AddRange(flower);
                lstFlowers.Visible = true;
                lblCongrats.Visible = true;
                lblCongrats.Text = "Good selection of " + occassion + " flowers";
            }
            else if (occassion.Equals("Birthday"))
            {
                // Populate the array in the new list box
                string[] flower = { "Carnation ", "Gladiolus" };
                lstFlowers.Items.AddRange(flower);
                lstFlowers.Visible = true;
                lblCongrats.Visible = true;
                lblCongrats.Text = "Good selection of " + occassion + " flowers";
            }
            else if (occassion.Equals("Christmas"))
            {
                // Populate the array in the new list box
                string[] flower = { "Iris ", "Scarbiosa" };
                lstFlowers.Items.AddRange(flower);
                lstFlowers.Visible = true;
                lblCongrats.Visible = true;
                lblCongrats.Text = "Good selection of " + occassion + " flowers";
            }
            else if (occassion.Equals("Valentines Day"))
            {
                // Populate the array in the new list box
                string[] flower = { "Tulips ", "Veronica", "Protea ", "Muscari " };
                lstFlowers.Items.AddRange(flower);
                lstFlowers.Visible = true;
                lblCongrats.Visible = true;
                lblCongrats.Text = "Good selection of " + occassion + " flowers";
            }


        }
    }
}
