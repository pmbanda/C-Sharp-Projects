namespace BedAndBreakfast
{
    partial class BreakfastOptionForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.radContinental = new System.Windows.Forms.RadioButton();
            this.radFull = new System.Windows.Forms.RadioButton();
            this.radDeluxe = new System.Windows.Forms.RadioButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(70, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(139, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Select your breakfast option";
            // 
            // radContinental
            // 
            this.radContinental.AutoSize = true;
            this.radContinental.Location = new System.Drawing.Point(73, 69);
            this.radContinental.Name = "radContinental";
            this.radContinental.Size = new System.Drawing.Size(78, 17);
            this.radContinental.TabIndex = 1;
            this.radContinental.TabStop = true;
            this.radContinental.Text = "Continental";
            this.radContinental.UseVisualStyleBackColor = true;
            this.radContinental.CheckedChanged += new System.EventHandler(this.radContinental_CheckedChanged);
            // 
            // radFull
            // 
            this.radFull.AutoSize = true;
            this.radFull.Location = new System.Drawing.Point(73, 108);
            this.radFull.Name = "radFull";
            this.radFull.Size = new System.Drawing.Size(41, 17);
            this.radFull.TabIndex = 2;
            this.radFull.TabStop = true;
            this.radFull.Text = "Full";
            this.radFull.UseVisualStyleBackColor = true;
            this.radFull.CheckedChanged += new System.EventHandler(this.radFull_CheckedChanged);
            // 
            // radDeluxe
            // 
            this.radDeluxe.AutoSize = true;
            this.radDeluxe.Location = new System.Drawing.Point(73, 148);
            this.radDeluxe.Name = "radDeluxe";
            this.radDeluxe.Size = new System.Drawing.Size(58, 17);
            this.radDeluxe.TabIndex = 3;
            this.radDeluxe.TabStop = true;
            this.radDeluxe.Text = "Deluxe";
            this.radDeluxe.UseVisualStyleBackColor = true;
            this.radDeluxe.CheckedChanged += new System.EventHandler(this.radDeluxe_CheckedChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(70, 188);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // BreakfastOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.radDeluxe);
            this.Controls.Add(this.radFull);
            this.Controls.Add(this.radContinental);
            this.Controls.Add(this.lblTitle);
            this.Name = "BreakfastOptionForm";
            this.Text = "BreakfastOptionForm";
            this.Load += new System.EventHandler(this.BreakfastOptionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radContinental;
        private System.Windows.Forms.RadioButton radFull;
        private System.Windows.Forms.RadioButton radDeluxe;
        private System.Windows.Forms.Label lblPrice;
    }
}