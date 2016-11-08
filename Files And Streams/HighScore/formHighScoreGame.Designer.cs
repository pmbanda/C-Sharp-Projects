namespace HighScore
{
    partial class frmHighScoreGame
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
            
            inFile.Close();
            myFile.Close();
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPreviousHighScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblGuessHeading = new System.Windows.Forms.Label();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lblUserScore = new System.Windows.Forms.Label();
            this.lblNewScore = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPreviousHighScore
            // 
            this.lblPreviousHighScore.AutoSize = true;
            this.lblPreviousHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousHighScore.Location = new System.Drawing.Point(12, 20);
            this.lblPreviousHighScore.Name = "lblPreviousHighScore";
            this.lblPreviousHighScore.Size = new System.Drawing.Size(128, 25);
            this.lblPreviousHighScore.TabIndex = 0;
            this.lblPreviousHighScore.Text = "High Score";
            this.lblPreviousHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Red;
            this.lblScore.Location = new System.Drawing.Point(9, 46);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(93, 42);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "XXX";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Visible = false;
            // 
            // lblGuessHeading
            // 
            this.lblGuessHeading.AutoSize = true;
            this.lblGuessHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessHeading.Location = new System.Drawing.Point(13, 99);
            this.lblGuessHeading.Name = "lblGuessHeading";
            this.lblGuessHeading.Size = new System.Drawing.Size(239, 24);
            this.lblGuessHeading.TabIndex = 2;
            this.lblGuessHeading.Text = "Enter a guess - (A , B or C )";
            this.lblGuessHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(17, 138);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(100, 20);
            this.txtEntry.TabIndex = 3;
            this.txtEntry.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblUserScore
            // 
            this.lblUserScore.AutoSize = true;
            this.lblUserScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserScore.Location = new System.Drawing.Point(179, 20);
            this.lblUserScore.Name = "lblUserScore";
            this.lblUserScore.Size = new System.Drawing.Size(73, 25);
            this.lblUserScore.TabIndex = 4;
            this.lblUserScore.Text = "Score";
            this.lblUserScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNewScore
            // 
            this.lblNewScore.AutoSize = true;
            this.lblNewScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewScore.ForeColor = System.Drawing.Color.Red;
            this.lblNewScore.Location = new System.Drawing.Point(177, 46);
            this.lblNewScore.Name = "lblNewScore";
            this.lblNewScore.Size = new System.Drawing.Size(93, 42);
            this.lblNewScore.TabIndex = 5;
            this.lblNewScore.Text = "XXX";
            this.lblNewScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNewScore.Visible = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(16, 178);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(14, 216);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 20);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResult.Visible = false;
            // 
            // frmHighScoreGame
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblNewScore);
            this.Controls.Add(this.lblUserScore);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.lblGuessHeading);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPreviousHighScore);
            this.Name = "frmHighScoreGame";
            this.Text = "High Score Game";
            this.Load += new System.EventHandler(this.frmHighScoreGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPreviousHighScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblGuessHeading;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Label lblUserScore;
        private System.Windows.Forms.Label lblNewScore;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblResult;
    }
}

