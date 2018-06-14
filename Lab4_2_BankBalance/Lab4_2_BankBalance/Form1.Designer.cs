namespace Lab4_2_BankBalance
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
            this.checkBalances = new System.Windows.Forms.Button();
            this.checkAccount = new System.Windows.Forms.TextBox();
            this.savingsAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your balances:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Checking Acount:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Savings Account:";
            // 
            // checkBalances
            // 
            this.checkBalances.Location = new System.Drawing.Point(129, 277);
            this.checkBalances.Name = "checkBalances";
            this.checkBalances.Size = new System.Drawing.Size(155, 23);
            this.checkBalances.TabIndex = 1;
            this.checkBalances.Text = "Check Balance";
            this.checkBalances.UseVisualStyleBackColor = true;
            this.checkBalances.Click += new System.EventHandler(this.checkBalances_Click);
            // 
            // checkAccount
            // 
            this.checkAccount.Location = new System.Drawing.Point(186, 135);
            this.checkAccount.Name = "checkAccount";
            this.checkAccount.Size = new System.Drawing.Size(100, 22);
            this.checkAccount.TabIndex = 2;
            // 
            // savingsAccount
            // 
            this.savingsAccount.Location = new System.Drawing.Point(186, 185);
            this.savingsAccount.Name = "savingsAccount";
            this.savingsAccount.Size = new System.Drawing.Size(100, 22);
            this.savingsAccount.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 496);
            this.Controls.Add(this.savingsAccount);
            this.Controls.Add(this.checkAccount);
            this.Controls.Add(this.checkBalances);
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
        private System.Windows.Forms.Button checkBalances;
        private System.Windows.Forms.TextBox checkAccount;
        private System.Windows.Forms.TextBox savingsAccount;
    }
}

