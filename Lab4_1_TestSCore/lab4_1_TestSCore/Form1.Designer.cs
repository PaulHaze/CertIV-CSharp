namespace lab4_1_TestSCore
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
            this.lblSCoreEntry = new System.Windows.Forms.Label();
            this.scoreEntered = new System.Windows.Forms.TextBox();
            this.checkScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSCoreEntry
            // 
            this.lblSCoreEntry.AutoSize = true;
            this.lblSCoreEntry.Location = new System.Drawing.Point(133, 90);
            this.lblSCoreEntry.Name = "lblSCoreEntry";
            this.lblSCoreEntry.Size = new System.Drawing.Size(164, 17);
            this.lblSCoreEntry.TabIndex = 0;
            this.lblSCoreEntry.Text = "Please Enter Your Score";
            // 
            // scoreEntered
            // 
            this.scoreEntered.Location = new System.Drawing.Point(136, 129);
            this.scoreEntered.Name = "scoreEntered";
            this.scoreEntered.Size = new System.Drawing.Size(161, 22);
            this.scoreEntered.TabIndex = 1;
           
            // 
            // checkScore
            // 
            this.checkScore.Location = new System.Drawing.Point(136, 196);
            this.checkScore.Name = "checkScore";
            this.checkScore.Size = new System.Drawing.Size(161, 23);
            this.checkScore.TabIndex = 2;
            this.checkScore.Text = "Check Score";
            this.checkScore.UseVisualStyleBackColor = true;
            this.checkScore.Click += new System.EventHandler(this.checkScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 437);
            this.Controls.Add(this.checkScore);
            this.Controls.Add(this.scoreEntered);
            this.Controls.Add(this.lblSCoreEntry);
            this.Name = "Form1";
            this.Text = "Form1";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSCoreEntry;
        private System.Windows.Forms.TextBox scoreEntered;
        private System.Windows.Forms.Button checkScore;
    }
}

