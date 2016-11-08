namespace Admission
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
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGPA = new System.Windows.Forms.TextBox();
            this.lblTestScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(24, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(156, 20);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "College Admission";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(12, 45);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(60, 13);
            this.lblGrade.TabIndex = 1;
            this.lblGrade.Text = "Enter GPA:";
            this.lblGrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGPA
            // 
            this.txtGPA.Location = new System.Drawing.Point(126, 42);
            this.txtGPA.Name = "txtGPA";
            this.txtGPA.Size = new System.Drawing.Size(54, 20);
            this.txtGPA.TabIndex = 2;
            this.txtGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTestScore
            // 
            this.lblTestScore.AutoSize = true;
            this.lblTestScore.Location = new System.Drawing.Point(12, 74);
            this.lblTestScore.Name = "lblTestScore";
            this.lblTestScore.Size = new System.Drawing.Size(85, 13);
            this.lblTestScore.TabIndex = 3;
            this.lblTestScore.Text = "Admission Score";
            this.lblTestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(126, 71);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(54, 20);
            this.txtScore.TabIndex = 4;
            this.txtScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Location = new System.Drawing.Point(12, 103);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(106, 110);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(49, 13);
            this.lblResponse.TabIndex = 6;
            this.lblResponse.Text = "XXXXXX";
            this.lblResponse.Visible = false;
            // 
            // myForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 152);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblTestScore);
            this.Controls.Add(this.txtGPA);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.lblHeading);
            this.Name = "myForm";
            this.Text = "Admission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGPA;
        private System.Windows.Forms.Label lblTestScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblResponse;
    }
}

