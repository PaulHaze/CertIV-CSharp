namespace ETS
{
    partial class AddHours
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
            this.cmbHoursId = new System.Windows.Forms.ComboBox();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.dateTimeAddHours = new System.Windows.Forms.DateTimePicker();
            this.btnAddHours = new System.Windows.Forms.Button();
            this.txtAddHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddHoursStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbHoursId
            // 
            this.cmbHoursId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHoursId.FormattingEnabled = true;
            this.cmbHoursId.Location = new System.Drawing.Point(30, 56);
            this.cmbHoursId.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHoursId.Name = "cmbHoursId";
            this.cmbHoursId.Size = new System.Drawing.Size(66, 33);
            this.cmbHoursId.TabIndex = 0;
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(104, 56);
            this.cmbEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(352, 33);
            this.cmbEmployeeName.TabIndex = 1;
            // 
            // dateTimeAddHours
            // 
            this.dateTimeAddHours.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeAddHours.Location = new System.Drawing.Point(30, 126);
            this.dateTimeAddHours.Name = "dateTimeAddHours";
            this.dateTimeAddHours.Size = new System.Drawing.Size(426, 27);
            this.dateTimeAddHours.TabIndex = 2;
            // 
            // btnAddHours
            // 
            this.btnAddHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddHours.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddHours.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHours.Location = new System.Drawing.Point(304, 275);
            this.btnAddHours.Name = "btnAddHours";
            this.btnAddHours.Size = new System.Drawing.Size(152, 70);
            this.btnAddHours.TabIndex = 3;
            this.btnAddHours.Text = "ADD HOURS";
            this.btnAddHours.UseVisualStyleBackColor = false;
            this.btnAddHours.Click += new System.EventHandler(this.btnAddHours_Click);
            // 
            // txtAddHours
            // 
            this.txtAddHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddHours.Location = new System.Drawing.Point(373, 207);
            this.txtAddHours.Margin = new System.Windows.Forms.Padding(3, 10, 10, 3);
            this.txtAddHours.Name = "txtAddHours";
            this.txtAddHours.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddHours.Size = new System.Drawing.Size(83, 30);
            this.txtAddHours.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(325, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(349, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Date Worked";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(339, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hours Worked";
            // 
            // lblAddHoursStatus
            // 
            this.lblAddHoursStatus.AutoSize = true;
            this.lblAddHoursStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddHoursStatus.Location = new System.Drawing.Point(25, 208);
            this.lblAddHoursStatus.Name = "lblAddHoursStatus";
            this.lblAddHoursStatus.Size = new System.Drawing.Size(85, 29);
            this.lblAddHoursStatus.TabIndex = 10;
            this.lblAddHoursStatus.Text = "Status:";
            // 
            // AddHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 373);
            this.Controls.Add(this.lblAddHoursStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddHours);
            this.Controls.Add(this.btnAddHours);
            this.Controls.Add(this.dateTimeAddHours);
            this.Controls.Add(this.cmbEmployeeName);
            this.Controls.Add(this.cmbHoursId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddHours";
            this.Text = "AddHours";
            this.Load += new System.EventHandler(this.AddHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHoursId;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.DateTimePicker dateTimeAddHours;
        private System.Windows.Forms.Button btnAddHours;
        private System.Windows.Forms.TextBox txtAddHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAddHoursStatus;
    }
}