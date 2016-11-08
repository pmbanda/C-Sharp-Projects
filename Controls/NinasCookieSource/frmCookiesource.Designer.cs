namespace NinasCookieSource
{
    partial class frmCookiesource
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
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.radHalfDozen = new System.Windows.Forms.RadioButton();
            this.radDozen = new System.Windows.Forms.RadioButton();
            this.radTwoDozen = new System.Windows.Forms.RadioButton();
            this.radThreeDozen = new System.Windows.Forms.RadioButton();
            this.grpDozenSelection = new System.Windows.Forms.GroupBox();
            this.calMyCalendar = new System.Windows.Forms.MonthCalendar();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblShipping = new System.Windows.Forms.Label();
            this.grpCookieType = new System.Windows.Forms.GroupBox();
            this.radOreo = new System.Windows.Forms.RadioButton();
            this.radPeanutButter = new System.Windows.Forms.RadioButton();
            this.radOatmeal = new System.Windows.Forms.RadioButton();
            this.lblCalendar = new System.Windows.Forms.Label();
            this.grpDozenSelection.SuspendLayout();
            this.grpCookieType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSelect.Location = new System.Drawing.Point(117, 45);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(0, 27);
            this.lblSelect.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblHeading.Location = new System.Drawing.Point(140, 21);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(184, 27);
            this.lblHeading.TabIndex = 4;
            this.lblHeading.Text = "The Cookie Source";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radHalfDozen
            // 
            this.radHalfDozen.AutoSize = true;
            this.radHalfDozen.Location = new System.Drawing.Point(6, 30);
            this.radHalfDozen.Name = "radHalfDozen";
            this.radHalfDozen.Size = new System.Drawing.Size(95, 22);
            this.radHalfDozen.TabIndex = 4;
            this.radHalfDozen.TabStop = true;
            this.radHalfDozen.Text = "Half Dozen";
            this.radHalfDozen.UseVisualStyleBackColor = true;
            // 
            // radDozen
            // 
            this.radDozen.AutoSize = true;
            this.radDozen.Location = new System.Drawing.Point(6, 54);
            this.radDozen.Name = "radDozen";
            this.radDozen.Size = new System.Drawing.Size(63, 22);
            this.radDozen.TabIndex = 5;
            this.radDozen.TabStop = true;
            this.radDozen.Text = "Dozen";
            this.radDozen.UseVisualStyleBackColor = true;
            // 
            // radTwoDozen
            // 
            this.radTwoDozen.AutoSize = true;
            this.radTwoDozen.Location = new System.Drawing.Point(109, 30);
            this.radTwoDozen.Name = "radTwoDozen";
            this.radTwoDozen.Size = new System.Drawing.Size(93, 22);
            this.radTwoDozen.TabIndex = 6;
            this.radTwoDozen.TabStop = true;
            this.radTwoDozen.Text = "Two Dozen";
            this.radTwoDozen.UseVisualStyleBackColor = true;
            // 
            // radThreeDozen
            // 
            this.radThreeDozen.AutoSize = true;
            this.radThreeDozen.Location = new System.Drawing.Point(109, 54);
            this.radThreeDozen.Name = "radThreeDozen";
            this.radThreeDozen.Size = new System.Drawing.Size(103, 22);
            this.radThreeDozen.TabIndex = 7;
            this.radThreeDozen.TabStop = true;
            this.radThreeDozen.Text = "Three Dozen";
            this.radThreeDozen.UseVisualStyleBackColor = true;
            // 
            // grpDozenSelection
            // 
            this.grpDozenSelection.Controls.Add(this.radHalfDozen);
            this.grpDozenSelection.Controls.Add(this.radThreeDozen);
            this.grpDozenSelection.Controls.Add(this.radDozen);
            this.grpDozenSelection.Controls.Add(this.radTwoDozen);
            this.grpDozenSelection.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDozenSelection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpDozenSelection.Location = new System.Drawing.Point(14, 157);
            this.grpDozenSelection.Name = "grpDozenSelection";
            this.grpDozenSelection.Size = new System.Drawing.Size(212, 88);
            this.grpDozenSelection.TabIndex = 9;
            this.grpDozenSelection.TabStop = false;
            this.grpDozenSelection.Text = "Dozen Selection";
            this.grpDozenSelection.Enter += new System.EventHandler(this.grpDozenSelection_Enter);
            // 
            // calMyCalendar
            // 
            this.calMyCalendar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.calMyCalendar.ForeColor = System.Drawing.Color.Black;
            this.calMyCalendar.Location = new System.Drawing.Point(238, 157);
            this.calMyCalendar.Name = "calMyCalendar";
            this.calMyCalendar.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSize = true;
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSubmit.Location = new System.Drawing.Point(12, 296);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Blue;
            this.lblPrice.Location = new System.Drawing.Point(9, 350);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(113, 26);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "$XXX.XXX";
            this.lblPrice.Visible = false;
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShipping.ForeColor = System.Drawing.Color.Blue;
            this.lblShipping.Location = new System.Drawing.Point(11, 406);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.Size = new System.Drawing.Size(131, 26);
            this.lblShipping.TabIndex = 13;
            this.lblShipping.Text = "Shipping Date";
            this.lblShipping.Visible = false;
            // 
            // grpCookieType
            // 
            this.grpCookieType.Controls.Add(this.radOreo);
            this.grpCookieType.Controls.Add(this.radPeanutButter);
            this.grpCookieType.Controls.Add(this.radOatmeal);
            this.grpCookieType.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCookieType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpCookieType.Location = new System.Drawing.Point(12, 56);
            this.grpCookieType.Name = "grpCookieType";
            this.grpCookieType.Size = new System.Drawing.Size(445, 61);
            this.grpCookieType.TabIndex = 14;
            this.grpCookieType.TabStop = false;
            this.grpCookieType.Text = "Cookie Type";
            this.grpCookieType.Enter += new System.EventHandler(this.grpCookieType_Enter);
            // 
            // radOreo
            // 
            this.radOreo.AutoSize = true;
            this.radOreo.Location = new System.Drawing.Point(300, 27);
            this.radOreo.Name = "radOreo";
            this.radOreo.Size = new System.Drawing.Size(62, 24);
            this.radOreo.TabIndex = 3;
            this.radOreo.TabStop = true;
            this.radOreo.Text = "Oreo";
            this.radOreo.UseVisualStyleBackColor = true;
            // 
            // radPeanutButter
            // 
            this.radPeanutButter.AutoSize = true;
            this.radPeanutButter.Location = new System.Drawing.Point(153, 27);
            this.radPeanutButter.Name = "radPeanutButter";
            this.radPeanutButter.Size = new System.Drawing.Size(124, 24);
            this.radPeanutButter.TabIndex = 2;
            this.radPeanutButter.TabStop = true;
            this.radPeanutButter.Text = "Peanut Butter";
            this.radPeanutButter.UseVisualStyleBackColor = true;
            // 
            // radOatmeal
            // 
            this.radOatmeal.AutoSize = true;
            this.radOatmeal.Location = new System.Drawing.Point(8, 27);
            this.radOatmeal.Name = "radOatmeal";
            this.radOatmeal.Size = new System.Drawing.Size(135, 24);
            this.radOatmeal.TabIndex = 1;
            this.radOatmeal.TabStop = true;
            this.radOatmeal.Text = "Oatmeal Cookie";
            this.radOatmeal.UseVisualStyleBackColor = true;
            // 
            // lblCalendar
            // 
            this.lblCalendar.AutoSize = true;
            this.lblCalendar.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalendar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCalendar.Location = new System.Drawing.Point(274, 128);
            this.lblCalendar.Name = "lblCalendar";
            this.lblCalendar.Size = new System.Drawing.Size(154, 20);
            this.lblCalendar.TabIndex = 15;
            this.lblCalendar.Text = "Select Shipping Date";
            this.lblCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCookiesource
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(482, 469);
            this.Controls.Add(this.lblCalendar);
            this.Controls.Add(this.grpCookieType);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.calMyCalendar);
            this.Controls.Add(this.grpDozenSelection);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.lblSelect);
            this.Name = "frmCookiesource";
            this.Text = "Cookie Source";
            this.Load += new System.EventHandler(this.frmCookie_Load);
            this.grpDozenSelection.ResumeLayout(false);
            this.grpDozenSelection.PerformLayout();
            this.grpCookieType.ResumeLayout(false);
            this.grpCookieType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.RadioButton radHalfDozen;
        private System.Windows.Forms.RadioButton radDozen;
        private System.Windows.Forms.RadioButton radTwoDozen;
        private System.Windows.Forms.RadioButton radThreeDozen;
        private System.Windows.Forms.GroupBox grpDozenSelection;
        private System.Windows.Forms.MonthCalendar calMyCalendar;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.GroupBox grpCookieType;
        private System.Windows.Forms.RadioButton radOreo;
        private System.Windows.Forms.RadioButton radPeanutButter;
        private System.Windows.Forms.RadioButton radOatmeal;
        private System.Windows.Forms.Label lblCalendar;
    }
}

