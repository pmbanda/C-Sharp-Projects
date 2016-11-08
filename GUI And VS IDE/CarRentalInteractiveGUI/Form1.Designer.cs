namespace CarRentalInteractiveGUI
{
    partial class carRentalForm
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
            this.daysLabel = new System.Windows.Forms.Label();
            this.milesLabel = new System.Windows.Forms.Label();
            this.rentDaysTextBox = new System.Windows.Forms.TextBox();
            this.milesTextBox = new System.Windows.Forms.TextBox();
            this.headingLabel = new System.Windows.Forms.Label();
            this.displayTotalLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daysLabel
            // 
            this.daysLabel.AutoSize = true;
            this.daysLabel.Location = new System.Drawing.Point(21, 44);
            this.daysLabel.Name = "daysLabel";
            this.daysLabel.Size = new System.Drawing.Size(65, 13);
            this.daysLabel.TabIndex = 1;
            this.daysLabel.Text = "Rental Days";
            // 
            // milesLabel
            // 
            this.milesLabel.AutoSize = true;
            this.milesLabel.Location = new System.Drawing.Point(21, 77);
            this.milesLabel.Name = "milesLabel";
            this.milesLabel.Size = new System.Drawing.Size(78, 13);
            this.milesLabel.TabIndex = 3;
            this.milesLabel.Text = "Miles Travelled";
            // 
            // rentDaysTextBox
            // 
            this.rentDaysTextBox.Location = new System.Drawing.Point(105, 41);
            this.rentDaysTextBox.Name = "rentDaysTextBox";
            this.rentDaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.rentDaysTextBox.TabIndex = 2;
            // 
            // milesTextBox
            // 
            this.milesTextBox.Location = new System.Drawing.Point(105, 74);
            this.milesTextBox.Name = "milesTextBox";
            this.milesTextBox.Size = new System.Drawing.Size(100, 20);
            this.milesTextBox.TabIndex = 4;
            // 
            // headingLabel
            // 
            this.headingLabel.AutoSize = true;
            this.headingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingLabel.Location = new System.Drawing.Point(66, 8);
            this.headingLabel.Name = "headingLabel";
            this.headingLabel.Size = new System.Drawing.Size(117, 24);
            this.headingLabel.TabIndex = 0;
            this.headingLabel.Text = "Car Rentals";
            // 
            // displayTotalLabel
            // 
            this.displayTotalLabel.AutoSize = true;
            this.displayTotalLabel.Location = new System.Drawing.Point(137, 110);
            this.displayTotalLabel.Name = "displayTotalLabel";
            this.displayTotalLabel.Size = new System.Drawing.Size(38, 13);
            this.displayTotalLabel.TabIndex = 6;
            this.displayTotalLabel.Text = "XX.XX";
            this.displayTotalLabel.Visible = false;
            this.displayTotalLabel.Click += new System.EventHandler(this.displayTotalLabel_Click);
            // 
            // totalButton
            // 
            this.totalButton.Location = new System.Drawing.Point(24, 105);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 5;
            this.totalButton.Text = "Total";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // carRentalForm
            // 
            this.AcceptButton = this.totalButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 150);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.displayTotalLabel);
            this.Controls.Add(this.headingLabel);
            this.Controls.Add(this.milesTextBox);
            this.Controls.Add(this.rentDaysTextBox);
            this.Controls.Add(this.milesLabel);
            this.Controls.Add(this.daysLabel);
            this.Name = "carRentalForm";
            this.Text = "Car Rental";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daysLabel;
        private System.Windows.Forms.Label milesLabel;
        private System.Windows.Forms.TextBox rentDaysTextBox;
        private System.Windows.Forms.TextBox milesTextBox;
        private System.Windows.Forms.Label headingLabel;
        private System.Windows.Forms.Label displayTotalLabel;
        private System.Windows.Forms.Button totalButton;
    }
}

