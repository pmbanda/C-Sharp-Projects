namespace BedAndBreakfast
{
    partial class belleAireForm
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
            this.belleAireDescriptionLabel = new System.Windows.Forms.Label();
            this.belleairePriceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // belleAireDescriptionLabel
            // 
            this.belleAireDescriptionLabel.AutoSize = true;
            this.belleAireDescriptionLabel.Location = new System.Drawing.Point(56, 37);
            this.belleAireDescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.belleAireDescriptionLabel.Name = "belleAireDescriptionLabel";
            this.belleAireDescriptionLabel.Size = new System.Drawing.Size(267, 42);
            this.belleAireDescriptionLabel.TabIndex = 0;
            this.belleAireDescriptionLabel.Text = "The Belle Aire suite has two bedrooms, two\r\nbaths, and a private balcony";
            // 
            // belleairePriceLabel
            // 
            this.belleairePriceLabel.AutoSize = true;
            this.belleairePriceLabel.Location = new System.Drawing.Point(150, 118);
            this.belleairePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.belleairePriceLabel.Name = "belleairePriceLabel";
            this.belleairePriceLabel.Size = new System.Drawing.Size(102, 21);
            this.belleairePriceLabel.TabIndex = 1;
            this.belleairePriceLabel.Text = "$19.95 per night";
            // 
            // belleAireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(426, 422);
            this.Controls.Add(this.belleairePriceLabel);
            this.Controls.Add(this.belleAireDescriptionLabel);
            this.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "belleAireForm";
            this.Text = "BelleAire Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label belleAireDescriptionLabel;
        private System.Windows.Forms.Label belleairePriceLabel;
    }
}