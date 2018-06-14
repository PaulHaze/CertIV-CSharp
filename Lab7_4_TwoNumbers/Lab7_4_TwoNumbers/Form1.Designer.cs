namespace Lab7_4_TwoNumbers
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
            this.txtNumOne = new System.Windows.Forms.TextBox();
            this.txtNumTwo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter two numbers in the boxes below:";
            // 
            // txtNumOne
            // 
            this.txtNumOne.Location = new System.Drawing.Point(144, 114);
            this.txtNumOne.Name = "txtNumOne";
            this.txtNumOne.Size = new System.Drawing.Size(100, 22);
            this.txtNumOne.TabIndex = 1;
            // 
            // txtNumTwo
            // 
            this.txtNumTwo.Location = new System.Drawing.Point(284, 114);
            this.txtNumTwo.Name = "txtNumTwo";
            this.txtNumTwo.Size = new System.Drawing.Size(100, 22);
            this.txtNumTwo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click Me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNumTwo);
            this.Controls.Add(this.txtNumOne);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumOne;
        private System.Windows.Forms.TextBox txtNumTwo;
        private System.Windows.Forms.Button button1;
    }
}

