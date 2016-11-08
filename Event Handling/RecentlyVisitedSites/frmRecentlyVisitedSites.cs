// Author:      Peter Eugene Mbanda
// Date:        5/13/2016
// Purpose:     Link labels application

using System;
using System.Windows.Forms;

namespace VisitedSites
{
    public partial class frmRecentlyVisitedSites : Form
    {
        // Create an array of Link labels
        LinkLabel[] sites = new LinkLabel[3];

        // Create links with the tool tips
        LinkLabel lnkQuora = new LinkLabel();
        ToolTip quora = new ToolTip();

        // Create links with the tool tips
        LinkLabel lnkIndeed = new LinkLabel();
        ToolTip indeed = new ToolTip();

        // Create links with the tool tips
        LinkLabel lnkHackerRank = new LinkLabel();
        ToolTip hackerRank = new ToolTip();

        public frmRecentlyVisitedSites()
        {
            InitializeComponent();
            
        }

        private void frmRecentlyVisitedSites_Load(object sender, EventArgs e)
        {
            // Populate the array with links 
            sites[0] = lnkQuora;
            quora.SetToolTip(lnkQuora, "Quora For Questions!");
            sites[1] = lnkIndeed;
            indeed.SetToolTip(lnkIndeed, "Qualified For Jobs!");
            sites[2] = lnkHackerRank;
            hackerRank.SetToolTip(lnkHackerRank, "Comfortable Coding?");

            // Configure the LinkLabel's properties. 
            this.lnkQuora.Location = new System.Drawing.Point(37, 36);
            this.lnkQuora.AutoSize = true;
            this.lnkQuora.Text = "Quora For Programmers";

            // Configure the LinkLabel's properties. 
            this.lnkIndeed.Location = new System.Drawing.Point(37, 56);
            this.lnkIndeed.AutoSize = true;
            this.lnkIndeed.Text = "Indeed For The Skilled";

            // Configure the LinkLabel's properties. 
            this.lnkHackerRank.Location = new System.Drawing.Point(37, 76);
            this.lnkHackerRank.AutoSize = true;
            this.lnkHackerRank.Text = "Hacker Rank For The Robust";

            for (int i = 0; i < sites.Length; i++)
            {
                // Assign the event handler to all the link labels
                this.Controls.Add(sites[i]);
                sites[i].LinkClicked += new LinkLabelLinkClickedEventHandler(EventGen);
            }

        }
        private void EventGen(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Determine the name of the link
            string nameOfLink = sender.ToString();
            
            // process the link depending on the name
            if(nameOfLink.Equals("System.Windows.Forms.LinkLabel, Text: Quora For Programmers"))
            {
                lnkQuora.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.quora.com/");
            }
            else if(nameOfLink.Equals("System.Windows.Forms.LinkLabel, Text: Indeed For The Skilled"))
            {
                lnkIndeed.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.indeed.com/");
            }
            else if(nameOfLink.Equals("System.Windows.Forms.LinkLabel, Text: Hacker Rank For The Robust"))
            {
                lnkHackerRank.LinkVisited = true;
                System.Diagnostics.Process.Start("https://www.hackerrank.com/");
            }

        }
    }
}
