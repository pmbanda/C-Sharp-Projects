namespace EventBegin
{
    partial class FormBegin
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
            this.btnChangeLabel = new System.Windows.Forms.Button();
            this.lblEventType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangeLabel
            // 
            this.btnChangeLabel.Location = new System.Drawing.Point(22, 23);
            this.btnChangeLabel.Name = "btnChangeLabel";
            this.btnChangeLabel.Size = new System.Drawing.Size(75, 23);
            this.btnChangeLabel.TabIndex = 0;
            this.btnChangeLabel.Text = "Change Label";
            this.btnChangeLabel.UseVisualStyleBackColor = true;
            this.btnChangeLabel.Click += new System.EventHandler(this.btnChangeLabel_Click);
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(19, 67);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(88, 13);
            this.lblEventType.TabIndex = 1;
            this.lblEventType.Text = "Event Generated";
            this.lblEventType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEventType.Visible = false;
            // 
            // FormBegin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 128);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.btnChangeLabel);
            this.Name = "FormBegin";
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangeLabel;
        private System.Windows.Forms.Label lblEventType;
    }
}

