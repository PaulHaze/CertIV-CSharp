namespace Lab7_2_Basic_Maths
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.btnStartMethods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number:";
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(196, 68);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(100, 22);
            this.txtUserNumber.TabIndex = 1;
            // 
            // btnStartMethods
            // 
            this.btnStartMethods.Location = new System.Drawing.Point(61, 116);
            this.btnStartMethods.Name = "btnStartMethods";
            this.btnStartMethods.Size = new System.Drawing.Size(235, 34);
            this.btnStartMethods.TabIndex = 2;
            this.btnStartMethods.Text = "Click Me!";
            this.btnStartMethods.UseVisualStyleBackColor = true;
            this.btnStartMethods.Click += new System.EventHandler(this.btnStartMethods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 253);
            this.Controls.Add(this.btnStartMethods);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.Button btnStartMethods;
    }
}

