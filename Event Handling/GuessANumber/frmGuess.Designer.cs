namespace GuessANumber
{
    partial class frmGuess
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
            this.radOne = new System.Windows.Forms.RadioButton();
            this.radTwo = new System.Windows.Forms.RadioButton();
            this.radThree = new System.Windows.Forms.RadioButton();
            this.radFour = new System.Windows.Forms.RadioButton();
            this.radFive = new System.Windows.Forms.RadioButton();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(12, 20);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(144, 16);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Guess a winning button";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // radOne
            // 
            this.radOne.AutoSize = true;
            this.radOne.Location = new System.Drawing.Point(15, 52);
            this.radOne.Name = "radOne";
            this.radOne.Size = new System.Drawing.Size(31, 17);
            this.radOne.TabIndex = 3;
            this.radOne.Text = "1";
            this.radOne.UseVisualStyleBackColor = true;
            this.radOne.CheckedChanged += new System.EventHandler(this.radOne_CheckedChanged);
            this.radOne.Click += new System.EventHandler(this.radOne_Click);
            // 
            // radTwo
            // 
            this.radTwo.AutoSize = true;
            this.radTwo.Location = new System.Drawing.Point(15, 75);
            this.radTwo.Name = "radTwo";
            this.radTwo.Size = new System.Drawing.Size(31, 17);
            this.radTwo.TabIndex = 4;
            this.radTwo.Text = "2";
            this.radTwo.UseVisualStyleBackColor = true;
            this.radTwo.CheckedChanged += new System.EventHandler(this.radTwo_CheckedChanged);
            this.radTwo.Click += new System.EventHandler(this.radOne_Click);
            // 
            // radThree
            // 
            this.radThree.AutoSize = true;
            this.radThree.Location = new System.Drawing.Point(15, 98);
            this.radThree.Name = "radThree";
            this.radThree.Size = new System.Drawing.Size(31, 17);
            this.radThree.TabIndex = 5;
            this.radThree.Text = "3";
            this.radThree.UseVisualStyleBackColor = true;
            this.radThree.CheckedChanged += new System.EventHandler(this.radThree_CheckedChanged);
            this.radThree.Click += new System.EventHandler(this.radOne_Click);
            // 
            // radFour
            // 
            this.radFour.AutoSize = true;
            this.radFour.Location = new System.Drawing.Point(15, 121);
            this.radFour.Name = "radFour";
            this.radFour.Size = new System.Drawing.Size(31, 17);
            this.radFour.TabIndex = 6;
            this.radFour.Text = "4";
            this.radFour.UseVisualStyleBackColor = true;
            this.radFour.CheckedChanged += new System.EventHandler(this.radFour_CheckedChanged);
            this.radFour.Click += new System.EventHandler(this.radOne_Click);
            // 
            // radFive
            // 
            this.radFive.AutoSize = true;
            this.radFive.Location = new System.Drawing.Point(15, 144);
            this.radFive.Name = "radFive";
            this.radFive.Size = new System.Drawing.Size(31, 17);
            this.radFive.TabIndex = 7;
            this.radFive.Text = "5";
            this.radFive.UseVisualStyleBackColor = true;
            this.radFive.CheckedChanged += new System.EventHandler(this.radFive_CheckedChanged);
            this.radFive.Click += new System.EventHandler(this.radOne_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(54, 98);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(102, 16);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Result of Guess";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Visible = false;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHint.Location = new System.Drawing.Point(12, 174);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(31, 16);
            this.lblHint.TabIndex = 9;
            this.lblHint.Text = "Hint";
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHint.MouseHover += new System.EventHandler(this.lblHint_MouseHover);
            // 
            // frmGuess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 218);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.radFive);
            this.Controls.Add(this.radFour);
            this.Controls.Add(this.radThree);
            this.Controls.Add(this.radTwo);
            this.Controls.Add(this.radOne);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmGuess";
            this.Text = "Guessing Game";
            this.Load += new System.EventHandler(this.frmGuess_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.RadioButton radOne;
        private System.Windows.Forms.RadioButton radTwo;
        private System.Windows.Forms.RadioButton radThree;
        private System.Windows.Forms.RadioButton radFour;
        private System.Windows.Forms.RadioButton radFive;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblHint;
    }
}

