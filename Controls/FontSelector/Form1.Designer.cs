namespace FontSelector
{
    partial class frmFontSelector
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
            this.lstFontNames = new System.Windows.Forms.ListBox();
            this.lstFontSize = new System.Windows.Forms.ListBox();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblFontName = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFontNames
            // 
            this.lstFontNames.FormattingEnabled = true;
            this.lstFontNames.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Times New Roman",
            "Lucida Console",
            "Lucida Sans Unicode"});
            this.lstFontNames.Location = new System.Drawing.Point(14, 81);
            this.lstFontNames.Name = "lstFontNames";
            this.lstFontNames.Size = new System.Drawing.Size(120, 69);
            this.lstFontNames.TabIndex = 0;
            // 
            // lstFontSize
            // 
            this.lstFontSize.FormattingEnabled = true;
            this.lstFontSize.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14"});
            this.lstFontSize.Location = new System.Drawing.Point(162, 81);
            this.lstFontSize.Name = "lstFontSize";
            this.lstFontSize.Size = new System.Drawing.Size(26, 69);
            this.lstFontSize.TabIndex = 1;
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontSize.Location = new System.Drawing.Point(159, 49);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(73, 16);
            this.lblFontSize.TabIndex = 2;
            this.lblFontSize.Text = "Font Size\'s";
            // 
            // lblFontName
            // 
            this.lblFontName.AutoSize = true;
            this.lblFontName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFontName.Location = new System.Drawing.Point(11, 49);
            this.lblFontName.Name = "lblFontName";
            this.lblFontName.Size = new System.Drawing.Size(84, 16);
            this.lblFontName.TabIndex = 3;
            this.lblFontName.Text = "Font Name\'s";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(49, 13);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(155, 24);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "Fonts Selection";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(105, 166);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(49, 13);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Text = "XXXXXX";
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 161);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmFontSelector
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 199);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblFontName);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.lstFontSize);
            this.Controls.Add(this.lstFontNames);
            this.Name = "frmFontSelector";
            this.Text = "Font Selector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFontNames;
        private System.Windows.Forms.ListBox lstFontSize;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblFontName;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnSubmit;
    }
}

