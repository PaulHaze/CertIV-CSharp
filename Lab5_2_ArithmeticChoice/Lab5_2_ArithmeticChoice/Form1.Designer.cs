namespace Lab5_2_ArithmeticChoice
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOperation = new System.Windows.Forms.TextBox();
            this.txtNumberOne = new System.Windows.Forms.TextBox();
            this.txtNumberTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the numbers you would like operate on:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number One:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Number Two:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(188, 295);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Please enter A or + to add";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Please enter S or - to subtract";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Please enter M or * to Multiply";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Please enter D or / to Divide";
            // 
            // txtOperation
            // 
            this.txtOperation.Location = new System.Drawing.Point(68, 296);
            this.txtOperation.Name = "txtOperation";
            this.txtOperation.Size = new System.Drawing.Size(100, 22);
            this.txtOperation.TabIndex = 3;
            // 
            // txtNumberOne
            // 
            this.txtNumberOne.Location = new System.Drawing.Point(188, 80);
            this.txtNumberOne.Name = "txtNumberOne";
            this.txtNumberOne.Size = new System.Drawing.Size(100, 22);
            this.txtNumberOne.TabIndex = 4;
            // 
            // txtNumberTwo
            // 
            this.txtNumberTwo.Location = new System.Drawing.Point(188, 123);
            this.txtNumberTwo.Name = "txtNumberTwo";
            this.txtNumberTwo.Size = new System.Drawing.Size(100, 22);
            this.txtNumberTwo.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 498);
            this.Controls.Add(this.txtNumberTwo);
            this.Controls.Add(this.txtNumberOne);
            this.Controls.Add(this.txtOperation);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOperation;
        private System.Windows.Forms.TextBox txtNumberOne;
        private System.Windows.Forms.TextBox txtNumberTwo;
    }
}

