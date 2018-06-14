namespace lab3_Windows
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
            this.floorSpaceHeader = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.lengthNumber = new System.Windows.Forms.TextBox();
            this.widthNumber = new System.Windows.Forms.TextBox();
            this.btnCaclulate = new System.Windows.Forms.Button();
            this.btnCalculate2 = new System.Windows.Forms.Button();
            this.btnCalculate3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // floorSpaceHeader
            // 
            this.floorSpaceHeader.AutoSize = true;
            this.floorSpaceHeader.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floorSpaceHeader.Location = new System.Drawing.Point(102, 45);
            this.floorSpaceHeader.Name = "floorSpaceHeader";
            this.floorSpaceHeader.Size = new System.Drawing.Size(267, 35);
            this.floorSpaceHeader.TabIndex = 0;
            this.floorSpaceHeader.Text = "Floor Space Calculator";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthLabel.Location = new System.Drawing.Point(42, 115);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(140, 29);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Length (cm)";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(42, 219);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(128, 29);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width (cm)";
            // 
            // lengthNumber
            // 
            this.lengthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lengthNumber.Location = new System.Drawing.Point(194, 115);
            this.lengthNumber.Name = "lengthNumber";
            this.lengthNumber.Size = new System.Drawing.Size(175, 30);
            this.lengthNumber.TabIndex = 3;
            // 
            // widthNumber
            // 
            this.widthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthNumber.Location = new System.Drawing.Point(194, 219);
            this.widthNumber.Name = "widthNumber";
            this.widthNumber.Size = new System.Drawing.Size(175, 30);
            this.widthNumber.TabIndex = 3;
            // 
            // btnCaclulate
            // 
            this.btnCaclulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaclulate.Location = new System.Drawing.Point(147, 291);
            this.btnCaclulate.Name = "btnCaclulate";
            this.btnCaclulate.Size = new System.Drawing.Size(201, 53);
            this.btnCaclulate.TabIndex = 4;
            this.btnCaclulate.Text = "Calculate";
            this.btnCaclulate.UseVisualStyleBackColor = true;
            this.btnCaclulate.Click += new System.EventHandler(this.btnCaclulate_Click);
            // 
            // btnCalculate2
            // 
            this.btnCalculate2.Location = new System.Drawing.Point(147, 364);
            this.btnCalculate2.Name = "btnCalculate2";
            this.btnCalculate2.Size = new System.Drawing.Size(201, 51);
            this.btnCalculate2.TabIndex = 5;
            this.btnCalculate2.Text = "Calculate2";
            this.btnCalculate2.UseVisualStyleBackColor = true;
            this.btnCalculate2.Click += new System.EventHandler(this.btnCalculate2_Click);
            // 
            // btnCalculate3
            // 
            this.btnCalculate3.Location = new System.Drawing.Point(147, 432);
            this.btnCalculate3.Name = "btnCalculate3";
            this.btnCalculate3.Size = new System.Drawing.Size(201, 23);
            this.btnCalculate3.TabIndex = 6;
            this.btnCalculate3.Text = "Calculate 3";
            this.btnCalculate3.UseVisualStyleBackColor = true;
            this.btnCalculate3.Click += new System.EventHandler(this.btnCalculate3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 477);
            this.Controls.Add(this.btnCalculate3);
            this.Controls.Add(this.btnCalculate2);
            this.Controls.Add(this.btnCaclulate);
            this.Controls.Add(this.widthNumber);
            this.Controls.Add(this.lengthNumber);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.floorSpaceHeader);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label floorSpaceHeader;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox lengthNumber;
        private System.Windows.Forms.TextBox widthNumber;
        private System.Windows.Forms.Button btnCaclulate;
        private System.Windows.Forms.Button btnCalculate2;
        private System.Windows.Forms.Button btnCalculate3;
    }
}

