namespace Lab8_2_CSharpArray
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
            this.btnTellMe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 88);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a number and Ill tell you why you like C#. Choose between 1 and 10";
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(101, 142);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(241, 22);
            this.txtUserNumber.TabIndex = 1;
            // 
            // btnTellMe
            // 
            this.btnTellMe.Location = new System.Drawing.Point(101, 190);
            this.btnTellMe.Name = "btnTellMe";
            this.btnTellMe.Size = new System.Drawing.Size(241, 65);
            this.btnTellMe.TabIndex = 2;
            this.btnTellMe.Text = "TELL ME!";
            this.btnTellMe.UseVisualStyleBackColor = true;
            this.btnTellMe.Click += new System.EventHandler(this.btnTellMe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 437);
            this.Controls.Add(this.btnTellMe);
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
        private System.Windows.Forms.Button btnTellMe;
    }
}

