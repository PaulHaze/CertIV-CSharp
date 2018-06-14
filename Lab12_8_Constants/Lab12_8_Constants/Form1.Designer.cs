namespace Lab12_8_Constants
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
            this.txtNumberEntered = new System.Windows.Forms.TextBox();
            this.btnConvertMetres = new System.Windows.Forms.Button();
            this.btnConvertCm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConversion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumberEntered
            // 
            this.txtNumberEntered.Location = new System.Drawing.Point(163, 120);
            this.txtNumberEntered.Name = "txtNumberEntered";
            this.txtNumberEntered.Size = new System.Drawing.Size(191, 22);
            this.txtNumberEntered.TabIndex = 0;
            // 
            // btnConvertMetres
            // 
            this.btnConvertMetres.Location = new System.Drawing.Point(163, 187);
            this.btnConvertMetres.Name = "btnConvertMetres";
            this.btnConvertMetres.Size = new System.Drawing.Size(191, 34);
            this.btnConvertMetres.TabIndex = 1;
            this.btnConvertMetres.Text = "Convert to Meters";
            this.btnConvertMetres.UseVisualStyleBackColor = true;
            this.btnConvertMetres.Click += new System.EventHandler(this.btnConvertMetres_Click);
            // 
            // btnConvertCm
            // 
            this.btnConvertCm.Location = new System.Drawing.Point(163, 244);
            this.btnConvertCm.Name = "btnConvertCm";
            this.btnConvertCm.Size = new System.Drawing.Size(191, 34);
            this.btnConvertCm.TabIndex = 1;
            this.btnConvertCm.Text = "Convert to Centimeters";
            this.btnConvertCm.UseVisualStyleBackColor = true;
            this.btnConvertCm.Click += new System.EventHandler(this.btnConvertCm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter number to be converted";
            // 
            // txtConversion
            // 
            this.txtConversion.Location = new System.Drawing.Point(163, 359);
            this.txtConversion.Name = "txtConversion";
            this.txtConversion.Size = new System.Drawing.Size(191, 22);
            this.txtConversion.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Converted total:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 546);
            this.Controls.Add(this.txtConversion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertCm);
            this.Controls.Add(this.btnConvertMetres);
            this.Controls.Add(this.txtNumberEntered);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumberEntered;
        private System.Windows.Forms.Button btnConvertMetres;
        private System.Windows.Forms.Button btnConvertCm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConversion;
        private System.Windows.Forms.Label label2;
    }
}

