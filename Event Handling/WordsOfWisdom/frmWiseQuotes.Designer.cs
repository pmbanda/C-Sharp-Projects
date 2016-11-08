namespace WordsOfWisdom
{
    partial class frmWiseQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWiseQuotes));
            this.lblQuoteBob = new System.Windows.Forms.Label();
            this.lblTupacQuote = new System.Windows.Forms.Label();
            this.lblBruceLee = new System.Windows.Forms.Label();
            this.lblrodneyQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuoteBob
            // 
            this.lblQuoteBob.AutoSize = true;
            this.lblQuoteBob.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuoteBob.Location = new System.Drawing.Point(33, 35);
            this.lblQuoteBob.Name = "lblQuoteBob";
            this.lblQuoteBob.Size = new System.Drawing.Size(279, 54);
            this.lblQuoteBob.TabIndex = 0;
            this.lblQuoteBob.Text = "Bob Marley\r\nEmancipate yourself from mental slavery \r\nnone but ourselves can free" +
    " our mind.";
            this.lblQuoteBob.Click += new System.EventHandler(this.lblQuoteBob_Click);
            this.lblQuoteBob.MouseHover += new System.EventHandler(this.lblQuoteBob_MouseHover);
            // 
            // lblTupacQuote
            // 
            this.lblTupacQuote.AutoSize = true;
            this.lblTupacQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTupacQuote.Location = new System.Drawing.Point(33, 117);
            this.lblTupacQuote.Name = "lblTupacQuote";
            this.lblTupacQuote.Size = new System.Drawing.Size(322, 126);
            this.lblTupacQuote.TabIndex = 1;
            this.lblTupacQuote.Text = resources.GetString("lblTupacQuote.Text");
            this.lblTupacQuote.MouseHover += new System.EventHandler(this.lblTupacQuote_MouseHover);
            // 
            // lblBruceLee
            // 
            this.lblBruceLee.AutoSize = true;
            this.lblBruceLee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruceLee.Location = new System.Drawing.Point(33, 271);
            this.lblBruceLee.Name = "lblBruceLee";
            this.lblBruceLee.Size = new System.Drawing.Size(397, 54);
            this.lblBruceLee.TabIndex = 2;
            this.lblBruceLee.Text = "Bruce Lee\r\nI fear not the man who has practiced 10,000 kicks once,\r\nbut I fear th" +
    "e man who has practiced one kick 10,000 times.\r\n";
            this.lblBruceLee.MouseHover += new System.EventHandler(this.lblBruceLee_MouseHover);
            // 
            // lblrodneyQuote
            // 
            this.lblrodneyQuote.AutoSize = true;
            this.lblrodneyQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrodneyQuote.Location = new System.Drawing.Point(33, 353);
            this.lblrodneyQuote.Name = "lblrodneyQuote";
            this.lblrodneyQuote.Size = new System.Drawing.Size(390, 126);
            this.lblrodneyQuote.TabIndex = 3;
            this.lblrodneyQuote.Text = resources.GetString("lblrodneyQuote.Text");
            this.lblrodneyQuote.Click += new System.EventHandler(this.label4_Click);
            this.lblrodneyQuote.MouseHover += new System.EventHandler(this.lblrodneyQuote_MouseHover);
            // 
            // frmWiseQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 551);
            this.Controls.Add(this.lblrodneyQuote);
            this.Controls.Add(this.lblBruceLee);
            this.Controls.Add(this.lblTupacQuote);
            this.Controls.Add(this.lblQuoteBob);
            this.Name = "frmWiseQuotes";
            this.Text = "Words Of Wisdom";
            this.Load += new System.EventHandler(this.frmWiseQuotes_Load);
            this.MouseHover += new System.EventHandler(this.frmWiseQuotes_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuoteBob;
        private System.Windows.Forms.Label lblTupacQuote;
        private System.Windows.Forms.Label lblBruceLee;
        private System.Windows.Forms.Label lblrodneyQuote;
    }
}

