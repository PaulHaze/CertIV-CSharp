namespace lab3_3_Payroll
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.TextBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblGrossPaid = new System.Windows.Forms.Label();
            this.lblNetPaid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Hourly Rate:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(92, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calculate Net Wage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Hours Worked:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // hours
            // 
            this.hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.Location = new System.Drawing.Point(253, 116);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(117, 30);
            this.hours.TabIndex = 2;
            // 
            // rate
            // 
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate.Location = new System.Drawing.Point(253, 218);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(117, 30);
            this.rate.TabIndex = 2;
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.Location = new System.Drawing.Point(51, 456);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(221, 25);
            this.lblNetPay.TabIndex = 0;
            this.lblNetPay.Text = "Total net pay earned is: ";
            this.lblNetPay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(30, 413);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(242, 25);
            this.lblGrossPay.TabIndex = 0;
            this.lblGrossPay.Text = "Total gross pay earned is: ";
            this.lblGrossPay.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGrossPaid
            // 
            this.lblGrossPaid.AutoSize = true;
            this.lblGrossPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPaid.Location = new System.Drawing.Point(279, 413);
            this.lblGrossPaid.Name = "lblGrossPaid";
            this.lblGrossPaid.Size = new System.Drawing.Size(0, 29);
            this.lblGrossPaid.TabIndex = 3;
            // 
            // lblNetPaid
            // 
            this.lblNetPaid.AutoSize = true;
            this.lblNetPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPaid.Location = new System.Drawing.Point(278, 456);
            this.lblNetPaid.Name = "lblNetPaid";
            this.lblNetPaid.Size = new System.Drawing.Size(0, 29);
            this.lblNetPaid.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 572);
            this.Controls.Add(this.lblNetPaid);
            this.Controls.Add(this.lblGrossPaid);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hours;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblGrossPaid;
        private System.Windows.Forms.Label lblNetPaid;
    }
}

