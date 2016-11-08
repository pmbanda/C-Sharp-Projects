namespace MonthNamesGUI
{
    partial class FormMonths
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
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.txtIntEntry = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(20, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(200, 18);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Month Names Application";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(20, 42);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(132, 13);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Enter month integer (1 -12)";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIntEntry
            // 
            this.txtIntEntry.Location = new System.Drawing.Point(23, 70);
            this.txtIntEntry.Name = "txtIntEntry";
            this.txtIntEntry.Size = new System.Drawing.Size(65, 20);
            this.txtIntEntry.TabIndex = 2;
            this.txtIntEntry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(20, 105);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(74, 13);
            this.lblDisplay.TabIndex = 3;
            this.lblDisplay.Text = "Display Month";
            this.lblDisplay.Visible = false;
            // 
            // btnConvert
            // 
            this.btnConvert.AutoSize = true;
            this.btnConvert.Location = new System.Drawing.Point(122, 68);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 4;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // FormMonths
            // 
            this.AcceptButton = this.btnConvert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 140);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtIntEntry);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblHeading);
            this.Name = "FormMonths";
            this.Text = "Month Names";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtIntEntry;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnConvert;
    }
}

