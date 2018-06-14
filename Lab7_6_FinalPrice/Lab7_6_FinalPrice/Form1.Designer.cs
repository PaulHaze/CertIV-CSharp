namespace Lab7_6_FinalPrice
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
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSalesCommission = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the price:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(79, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 49);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please enter the sales commission rate (%):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(79, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "Please enter the customers discount rate (%):";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(298, 52);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // txtSalesCommission
            // 
            this.txtSalesCommission.Location = new System.Drawing.Point(298, 109);
            this.txtSalesCommission.Name = "txtSalesCommission";
            this.txtSalesCommission.Size = new System.Drawing.Size(100, 22);
            this.txtSalesCommission.TabIndex = 1;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(298, 178);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscount.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(121, 234);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(277, 44);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate Final Price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 398);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtSalesCommission);
            this.Controls.Add(this.txtPrice);
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
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSalesCommission;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Button btnCalculate;
    }
}

