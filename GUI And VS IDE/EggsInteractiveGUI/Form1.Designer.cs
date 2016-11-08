namespace EggsInteractiveGUI
{
    partial class Form1
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
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(12, 19);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(214, 13);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Enter eggs produced by each of 5 chickens";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(15, 50);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(41, 20);
            this.txtBox1.TabIndex = 1;
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(73, 50);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(41, 20);
            this.txtBox2.TabIndex = 2;
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(131, 50);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(41, 20);
            this.txtBox3.TabIndex = 3;
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(15, 88);
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(41, 20);
            this.txtBox4.TabIndex = 4;
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(73, 88);
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(41, 20);
            this.txtBox5.TabIndex = 5;
            // 
            // btnClick
            // 
            this.btnClick.AutoSize = true;
            this.btnClick.Location = new System.Drawing.Point(51, 124);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(98, 23);
            this.btnClick.TabIndex = 6;
            this.btnClick.Text = "Click to calculate";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 167);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(184, 13);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "xxx eggs is xx dozens with xx left over";
            this.lblTotal.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClick;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 197);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lblHeading);
            this.Name = "Form1";
            this.Text = "Egg Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.TextBox txtBox5;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblTotal;
    }
}

