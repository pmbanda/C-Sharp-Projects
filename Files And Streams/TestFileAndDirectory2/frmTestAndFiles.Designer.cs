namespace TestFileAndDirectory2
{
    partial class frmTestAndFile
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
            this.lblFileSelect = new System.Windows.Forms.Label();
            this.chkLstBoxDirectory = new System.Windows.Forms.CheckedListBox();
            this.lblHeadingInfo = new System.Windows.Forms.Label();
            this.lblInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFileSelect
            // 
            this.lblFileSelect.AutoSize = true;
            this.lblFileSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileSelect.Location = new System.Drawing.Point(34, 21);
            this.lblFileSelect.Name = "lblFileSelect";
            this.lblFileSelect.Size = new System.Drawing.Size(91, 20);
            this.lblFileSelect.TabIndex = 0;
            this.lblFileSelect.Text = "Select a file";
            this.lblFileSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkLstBoxDirectory
            // 
            this.chkLstBoxDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLstBoxDirectory.FormattingEnabled = true;
            this.chkLstBoxDirectory.Location = new System.Drawing.Point(38, 61);
            this.chkLstBoxDirectory.Name = "chkLstBoxDirectory";
            this.chkLstBoxDirectory.Size = new System.Drawing.Size(305, 106);
            this.chkLstBoxDirectory.TabIndex = 1;
            this.chkLstBoxDirectory.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lblHeadingInfo
            // 
            this.lblHeadingInfo.AutoSize = true;
            this.lblHeadingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingInfo.Location = new System.Drawing.Point(34, 187);
            this.lblHeadingInfo.Name = "lblHeadingInfo";
            this.lblHeadingInfo.Size = new System.Drawing.Size(158, 20);
            this.lblHeadingInfo.TabIndex = 2;
            this.lblHeadingInfo.Text = "Creation Information:";
            this.lblHeadingInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformation.Location = new System.Drawing.Point(35, 227);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(119, 20);
            this.lblInformation.TabIndex = 3;
            this.lblInformation.Text = "File Information";
            this.lblInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmTestAndFile
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 303);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lblHeadingInfo);
            this.Controls.Add(this.chkLstBoxDirectory);
            this.Controls.Add(this.lblFileSelect);
            this.Name = "frmTestAndFile";
            this.Text = "Test And File Directory";
            this.Load += new System.EventHandler(this.frmTestAndFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileSelect;
        private System.Windows.Forms.CheckedListBox chkLstBoxDirectory;
        private System.Windows.Forms.Label lblHeadingInfo;
        private System.Windows.Forms.Label lblInformation;
    }
}

