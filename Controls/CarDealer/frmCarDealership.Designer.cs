namespace CarDealer
{
    partial class frmCarDealership
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
            this.radLexus = new System.Windows.Forms.RadioButton();
            this.radBmw = new System.Windows.Forms.RadioButton();
            this.radMercedes = new System.Windows.Forms.RadioButton();
            this.lblHeading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radLexus
            // 
            this.radLexus.AutoSize = true;
            this.radLexus.Location = new System.Drawing.Point(90, 138);
            this.radLexus.Name = "radLexus";
            this.radLexus.Size = new System.Drawing.Size(53, 17);
            this.radLexus.TabIndex = 5;
            this.radLexus.Text = "Lexus";
            this.radLexus.UseVisualStyleBackColor = true;
            this.radLexus.CheckedChanged += new System.EventHandler(this.radLexus_CheckedChanged);
            // 
            // radBmw
            // 
            this.radBmw.AutoSize = true;
            this.radBmw.Location = new System.Drawing.Point(90, 98);
            this.radBmw.Name = "radBmw";
            this.radBmw.Size = new System.Drawing.Size(52, 17);
            this.radBmw.TabIndex = 4;
            this.radBmw.Text = "BMW";
            this.radBmw.UseVisualStyleBackColor = true;
            this.radBmw.CheckedChanged += new System.EventHandler(this.radBmw_CheckedChanged);
            // 
            // radMercedes
            // 
            this.radMercedes.AutoSize = true;
            this.radMercedes.Location = new System.Drawing.Point(90, 62);
            this.radMercedes.Name = "radMercedes";
            this.radMercedes.Size = new System.Drawing.Size(72, 17);
            this.radMercedes.TabIndex = 3;
            this.radMercedes.Text = "Mercedes";
            this.radMercedes.UseVisualStyleBackColor = true;
            this.radMercedes.CheckedChanged += new System.EventHandler(this.radMercedes_CheckedChanged);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(70, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(113, 20);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Kings Motors";
            // 
            // frmCarDealership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(253, 198);
            this.Controls.Add(this.radLexus);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.radBmw);
            this.Controls.Add(this.radMercedes);
            this.Name = "frmCarDealership";
            this.RightToLeftLayout = true;
            this.Text = "Car Dealership";
            this.Load += new System.EventHandler(this.frmCarDealership_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radLexus;
        private System.Windows.Forms.RadioButton radBmw;
        private System.Windows.Forms.RadioButton radMercedes;
        private System.Windows.Forms.Label lblHeading;
    }
}

