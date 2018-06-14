namespace Lab7_5_CalcPay
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
            this.txtHourRate = new System.Windows.Forms.TextBox();
            this.txtNormalHours = new System.Windows.Forms.TextBox();
            this.txtOvertimeHours = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your hourly rate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please enter your normal hours:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Please enter your overtime hours:";
            // 
            // txtHourRate
            // 
            this.txtHourRate.Location = new System.Drawing.Point(343, 87);
            this.txtHourRate.Name = "txtHourRate";
            this.txtHourRate.Size = new System.Drawing.Size(100, 22);
            this.txtHourRate.TabIndex = 1;
            // 
            // txtNormalHours
            // 
            this.txtNormalHours.Location = new System.Drawing.Point(343, 138);
            this.txtNormalHours.Name = "txtNormalHours";
            this.txtNormalHours.Size = new System.Drawing.Size(100, 22);
            this.txtNormalHours.TabIndex = 1;
            // 
            // txtOvertimeHours
            // 
            this.txtOvertimeHours.Location = new System.Drawing.Point(343, 186);
            this.txtOvertimeHours.Name = "txtOvertimeHours";
            this.txtOvertimeHours.Size = new System.Drawing.Size(100, 22);
            this.txtOvertimeHours.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate Pay";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 422);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOvertimeHours);
            this.Controls.Add(this.txtNormalHours);
            this.Controls.Add(this.txtHourRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHourRate;
        private System.Windows.Forms.TextBox txtNormalHours;
        private System.Windows.Forms.TextBox txtOvertimeHours;
        private System.Windows.Forms.Button button1;
    }
}

