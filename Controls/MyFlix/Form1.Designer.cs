namespace MyFlix
{
    partial class frmMovies
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBoxMovies = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstBoxMovies
            // 
            this.lstBoxMovies.FormattingEnabled = true;
            this.lstBoxMovies.Items.AddRange(new object[] {
            "The Collector",
            "Texas Chainsaw Massacre",
            "The Concussions",
            "X-Files",
            "Kennedy\'s Assasination",
            "The Perfect Strangers"});
            this.lstBoxMovies.Location = new System.Drawing.Point(25, 122);
            this.lstBoxMovies.Name = "lstBoxMovies";
            this.lstBoxMovies.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstBoxMovies.Size = new System.Drawing.Size(142, 95);
            this.lstBoxMovies.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(22, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Choose as many movies as you want \r\nby holding down Ctr-Key while making\r\nselecti" +
    "ons";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(95, 18);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(94, 24);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "My Flix";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(25, 233);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(128, 238);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(39, 13);
            this.lblDisplay.TabIndex = 4;
            this.lblDisplay.Text = "********";
            // 
            // frmMovies
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 288);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstBoxMovies);
            this.Name = "frmMovies";
            this.Text = "Movie Selection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxMovies;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDisplay;
    }
}

