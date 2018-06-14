namespace Lab6_5_Goals
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
            this.txtSales = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSalesGoals = new System.Windows.Forms.Label();
            this.lblGoalsRemaining = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your current sales amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of years:";
            // 
            // txtSales
            // 
            this.txtSales.Location = new System.Drawing.Point(251, 59);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(100, 22);
            this.txtSales.TabIndex = 1;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(251, 99);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(100, 22);
            this.txtYears.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your current sales goals:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Sales goals for the remaining years:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesGoals
            // 
            this.lblSalesGoals.Location = new System.Drawing.Point(260, 171);
            this.lblSalesGoals.Name = "lblSalesGoals";
            this.lblSalesGoals.Size = new System.Drawing.Size(166, 17);
            this.lblSalesGoals.TabIndex = 2;
            this.lblSalesGoals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGoalsRemaining
            // 
            this.lblGoalsRemaining.Location = new System.Drawing.Point(260, 212);
            this.lblGoalsRemaining.Name = "lblGoalsRemaining";
            this.lblGoalsRemaining.Size = new System.Drawing.Size(235, 250);
            this.lblGoalsRemaining.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(379, 59);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(116, 62);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate Goals";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 512);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGoalsRemaining);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSalesGoals);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtSales);
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
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSalesGoals;
        private System.Windows.Forms.Label lblGoalsRemaining;
        private System.Windows.Forms.Button btnCalculate;
    }
}

