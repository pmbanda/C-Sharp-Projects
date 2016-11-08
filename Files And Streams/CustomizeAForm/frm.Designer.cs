namespace CustomizeAForm
{
    partial class frm
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

            outFile.Close();
            file.Close();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpColors = new System.Windows.Forms.GroupBox();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radNormal = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTitleSelected = new System.Windows.Forms.Label();
            this.grpColors.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackgroundColor.Location = new System.Drawing.Point(61, 14);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(136, 20);
            this.lblBackgroundColor.TabIndex = 0;
            this.lblBackgroundColor.Text = "Background Color";
            this.lblBackgroundColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(205, 14);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(40, 20);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(61, 171);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 20);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title:";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpColors
            // 
            this.grpColors.Controls.Add(this.radBlue);
            this.grpColors.Controls.Add(this.radGreen);
            this.grpColors.Controls.Add(this.radRed);
            this.grpColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpColors.Location = new System.Drawing.Point(65, 50);
            this.grpColors.Name = "grpColors";
            this.grpColors.Size = new System.Drawing.Size(113, 100);
            this.grpColors.TabIndex = 2;
            this.grpColors.TabStop = false;
            this.grpColors.Text = "Select Color";
            this.grpColors.Enter += new System.EventHandler(this.grpColors_Enter);
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(11, 65);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(59, 24);
            this.radBlue.TabIndex = 5;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "Blue";
            this.radBlue.UseVisualStyleBackColor = true;
            this.radBlue.CheckedChanged += new System.EventHandler(this.radBlue_CheckedChanged);
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(11, 42);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(72, 24);
            this.radGreen.TabIndex = 4;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "Green";
            this.radGreen.UseVisualStyleBackColor = true;
            this.radGreen.CheckedChanged += new System.EventHandler(this.radGreen_CheckedChanged);
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(11, 19);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(57, 24);
            this.radRed.TabIndex = 3;
            this.radRed.TabStop = true;
            this.radRed.Text = "Red";
            this.radRed.UseVisualStyleBackColor = true;
            this.radRed.CheckedChanged += new System.EventHandler(this.radRed_CheckedChanged);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radNormal);
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(206, 45);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(117, 105);
            this.grpSize.TabIndex = 6;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Select Size";
            this.grpSize.Enter += new System.EventHandler(this.grpSize_Enter);
            // 
            // radNormal
            // 
            this.radNormal.AutoSize = true;
            this.radNormal.Location = new System.Drawing.Point(3, 43);
            this.radNormal.Name = "radNormal";
            this.radNormal.Size = new System.Drawing.Size(77, 24);
            this.radNormal.TabIndex = 8;
            this.radNormal.TabStop = true;
            this.radNormal.Text = "Normal";
            this.radNormal.UseVisualStyleBackColor = true;
            this.radNormal.CheckedChanged += new System.EventHandler(this.radNormal_CheckedChanged);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(3, 70);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(68, 24);
            this.radLarge.TabIndex = 9;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radLarge_CheckedChanged);
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(3, 16);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(66, 24);
            this.radSmall.TabIndex = 7;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.UseVisualStyleBackColor = true;
            this.radSmall.CheckedChanged += new System.EventHandler(this.radSmall_CheckedChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(65, 203);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(88, 40);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Save\r\nSettings";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTitleSelected
            // 
            this.lblTitleSelected.AutoSize = true;
            this.lblTitleSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSelected.Location = new System.Drawing.Point(119, 171);
            this.lblTitleSelected.Name = "lblTitleSelected";
            this.lblTitleSelected.Size = new System.Drawing.Size(105, 20);
            this.lblTitleSelected.TabIndex = 11;
            this.lblTitleSelected.Text = "Title Selected";
            this.lblTitleSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitleSelected.Visible = false;
            // 
            // frm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 276);
            this.Controls.Add(this.lblTitleSelected);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpColors);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblBackgroundColor);
            this.Name = "frm";
            this.Text = "Form Selector";
            this.Load += new System.EventHandler(this.frm_Load);
            this.grpColors.ResumeLayout(false);
            this.grpColors.PerformLayout();
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpColors;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTitleSelected;
        private System.Windows.Forms.RadioButton radNormal;
    }
}

