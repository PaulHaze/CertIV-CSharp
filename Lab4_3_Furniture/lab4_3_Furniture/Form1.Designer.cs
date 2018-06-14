namespace lab4_3_Furniture
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
            this.components = new System.ComponentModel.Container();
            this.lblWood = new System.Windows.Forms.Label();
            this.woodEntered = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWoodChosen = new System.Windows.Forms.Label();
            this.lblCostTable = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWood
            // 
            this.lblWood.AutoSize = true;
            this.lblWood.Location = new System.Drawing.Point(71, 66);
            this.lblWood.Name = "lblWood";
            this.lblWood.Size = new System.Drawing.Size(254, 17);
            this.lblWood.TabIndex = 0;
            this.lblWood.Text = "Enter your wood selection: Pine or Oak";
            // 
            // woodEntered
            // 
            this.woodEntered.Location = new System.Drawing.Point(109, 96);
            this.woodEntered.Name = "woodEntered";
            this.woodEntered.Size = new System.Drawing.Size(172, 22);
            this.woodEntered.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wood Chosen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cost Of Table:";
            // 
            // lblWoodChosen
            // 
            this.lblWoodChosen.AutoSize = true;
            this.lblWoodChosen.Location = new System.Drawing.Point(213, 180);
            this.lblWoodChosen.Name = "lblWoodChosen";
            this.lblWoodChosen.Size = new System.Drawing.Size(0, 17);
            this.lblWoodChosen.TabIndex = 0;
            // 
            // lblCostTable
            // 
            this.lblCostTable.AutoSize = true;
            this.lblCostTable.Location = new System.Drawing.Point(211, 219);
            this.lblCostTable.Name = "lblCostTable";
            this.lblCostTable.Size = new System.Drawing.Size(0, 17);
            this.lblCostTable.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Find Price";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.woodEntered);
            this.Controls.Add(this.lblCostTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWoodChosen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWood);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWood;
        private System.Windows.Forms.TextBox woodEntered;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWoodChosen;
        private System.Windows.Forms.Label lblCostTable;
        private System.Windows.Forms.Button button1;
    }
}

