namespace lab5_2_Temperature
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
            this.lblTemperatures = new System.Windows.Forms.Label();
            this.btnConvertTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click button to convert temperatures";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Converted temperatures are:";
            // 
            // lblTemperatures
            // 
            this.lblTemperatures.Location = new System.Drawing.Point(56, 163);
            this.lblTemperatures.Name = "lblTemperatures";
            this.lblTemperatures.Size = new System.Drawing.Size(376, 588);
            this.lblTemperatures.TabIndex = 1;
            // 
            // btnConvertTemp
            // 
            this.btnConvertTemp.Location = new System.Drawing.Point(118, 63);
            this.btnConvertTemp.Name = "btnConvertTemp";
            this.btnConvertTemp.Size = new System.Drawing.Size(198, 58);
            this.btnConvertTemp.TabIndex = 2;
            this.btnConvertTemp.Text = "Click To Convert";
            this.btnConvertTemp.UseVisualStyleBackColor = true;
            this.btnConvertTemp.Click += new System.EventHandler(this.btnConvertTemp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 770);
            this.Controls.Add(this.btnConvertTemp);
            this.Controls.Add(this.lblTemperatures);
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
        private System.Windows.Forms.Label lblTemperatures;
        private System.Windows.Forms.Button btnConvertTemp;
    }
}

