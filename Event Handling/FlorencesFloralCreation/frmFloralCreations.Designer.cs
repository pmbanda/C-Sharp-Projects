namespace FlorencesFloralCreation
{
    partial class frmFloralCreations
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
            this.lstOccassion = new System.Windows.Forms.ListBox();
            this.lstFlowers = new System.Windows.Forms.ListBox();
            this.lblOccassion = new System.Windows.Forms.Label();
            this.lblFlowerLabel = new System.Windows.Forms.Label();
            this.lblCongrats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(33, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(231, 24);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Florences Floral Creations";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstOccassion
            // 
            this.lstOccassion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOccassion.FormattingEnabled = true;
            this.lstOccassion.ItemHeight = 18;
            this.lstOccassion.Items.AddRange(new object[] {
            "Get Well",
            "Graduation",
            "Birthday",
            "Christmas",
            "Valentines Day"});
            this.lstOccassion.Location = new System.Drawing.Point(36, 71);
            this.lstOccassion.Name = "lstOccassion";
            this.lstOccassion.Size = new System.Drawing.Size(115, 94);
            this.lstOccassion.TabIndex = 1;
            this.lstOccassion.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lstFlowers
            // 
            this.lstFlowers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFlowers.FormattingEnabled = true;
            this.lstFlowers.ItemHeight = 18;
            this.lstFlowers.Location = new System.Drawing.Point(184, 71);
            this.lstFlowers.Name = "lstFlowers";
            this.lstFlowers.Size = new System.Drawing.Size(79, 76);
            this.lstFlowers.TabIndex = 2;
            this.lstFlowers.Visible = false;
            // 
            // lblOccassion
            // 
            this.lblOccassion.AutoSize = true;
            this.lblOccassion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccassion.Location = new System.Drawing.Point(33, 43);
            this.lblOccassion.Name = "lblOccassion";
            this.lblOccassion.Size = new System.Drawing.Size(72, 16);
            this.lblOccassion.TabIndex = 3;
            this.lblOccassion.Text = "Occassion";
            this.lblOccassion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlowerLabel
            // 
            this.lblFlowerLabel.AutoSize = true;
            this.lblFlowerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowerLabel.Location = new System.Drawing.Point(181, 46);
            this.lblFlowerLabel.Name = "lblFlowerLabel";
            this.lblFlowerLabel.Size = new System.Drawing.Size(55, 16);
            this.lblFlowerLabel.TabIndex = 4;
            this.lblFlowerLabel.Text = "Flowers";
            this.lblFlowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCongrats
            // 
            this.lblCongrats.AutoSize = true;
            this.lblCongrats.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCongrats.Location = new System.Drawing.Point(34, 185);
            this.lblCongrats.Name = "lblCongrats";
            this.lblCongrats.Size = new System.Drawing.Size(96, 15);
            this.lblCongrats.TabIndex = 5;
            this.lblCongrats.Text = "Congratulations";
            this.lblCongrats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCongrats.Visible = false;
            // 
            // frmFloralCreations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 221);
            this.Controls.Add(this.lblCongrats);
            this.Controls.Add(this.lblFlowerLabel);
            this.Controls.Add(this.lblOccassion);
            this.Controls.Add(this.lstFlowers);
            this.Controls.Add(this.lstOccassion);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmFloralCreations";
            this.Text = "Floral Creations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ListBox lstOccassion;
        private System.Windows.Forms.ListBox lstFlowers;
        private System.Windows.Forms.Label lblOccassion;
        private System.Windows.Forms.Label lblFlowerLabel;
        private System.Windows.Forms.Label lblCongrats;
    }
}

