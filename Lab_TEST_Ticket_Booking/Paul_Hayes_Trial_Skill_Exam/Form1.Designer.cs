namespace Paul_Hayes_Trial_Skill_Exam
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
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnTotalSpend = new System.Windows.Forms.Button();
            this.btnSeatsAvailable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please Enter the seat number you would like:";
            // 
            // txtTicket
            // 
            this.txtTicket.Location = new System.Drawing.Point(257, 94);
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(59, 20);
            this.txtTicket.TabIndex = 2;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(109, 154);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(152, 36);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check Availability";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnTotalSpend
            // 
            this.btnTotalSpend.Location = new System.Drawing.Point(109, 207);
            this.btnTotalSpend.Name = "btnTotalSpend";
            this.btnTotalSpend.Size = new System.Drawing.Size(152, 36);
            this.btnTotalSpend.TabIndex = 4;
            this.btnTotalSpend.Text = "View Total Spend";
            this.btnTotalSpend.UseVisualStyleBackColor = true;
            this.btnTotalSpend.Click += new System.EventHandler(this.btnTotalSpend_Click);
            // 
            // btnSeatsAvailable
            // 
            this.btnSeatsAvailable.Location = new System.Drawing.Point(109, 260);
            this.btnSeatsAvailable.Name = "btnSeatsAvailable";
            this.btnSeatsAvailable.Size = new System.Drawing.Size(152, 36);
            this.btnSeatsAvailable.TabIndex = 4;
            this.btnSeatsAvailable.Text = "Seats Remaining";
            this.btnSeatsAvailable.UseVisualStyleBackColor = true;
            this.btnSeatsAvailable.Click += new System.EventHandler(this.btnSeatsAvailable_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 382);
            this.Controls.Add(this.btnSeatsAvailable);
            this.Controls.Add(this.btnTotalSpend);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtTicket);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnTotalSpend;
        private System.Windows.Forms.Button btnSeatsAvailable;
    }
}

