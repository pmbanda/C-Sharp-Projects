namespace GuessingGame
{
    partial class myForm
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
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblComp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(21, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(216, 18);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Guessing Game Application";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(21, 43);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(108, 13);
            this.lblPrompt.TabIndex = 1;
            this.lblPrompt.Text = "Enter Guess Number:";
            this.lblPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(150, 40);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(64, 20);
            this.txtGuess.TabIndex = 2;
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(21, 76);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 3;
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(88, 140);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(82, 13);
            this.lblDisplay.TabIndex = 6;
            this.lblDisplay.Text = "Result of Guess";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDisplay.Visible = false;
            // 
            // btnResult
            // 
            this.btnResult.AutoSize = true;
            this.btnResult.Location = new System.Drawing.Point(92, 73);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(78, 111);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(102, 13);
            this.lblComp.TabIndex = 5;
            this.lblComp.Text = "Computer Generator";
            this.lblComp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComp.Visible = false;
            // 
            // myForm
            // 
            this.AcceptButton = this.btnResult;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 176);
            this.Controls.Add(this.lblComp);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblHeading);
            this.Name = "myForm";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblComp;
    }
}

