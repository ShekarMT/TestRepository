namespace SampleEditing
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
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.btnFire = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.BackColor = System.Drawing.Color.Maroon;
            this.lblStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblStart.Location = new System.Drawing.Point(80, 70);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(172, 37);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Select Start Time";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEnd
            // 
            this.lblEnd.BackColor = System.Drawing.Color.Maroon;
            this.lblEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblEnd.Location = new System.Drawing.Point(80, 144);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(172, 37);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "Select End Time";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(319, 70);
            this.txtStart.Multiline = true;
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(230, 37);
            this.txtStart.TabIndex = 2;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(319, 144);
            this.txtEnd.Multiline = true;
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(230, 37);
            this.txtEnd.TabIndex = 3;
            // 
            // btnFire
            // 
            this.btnFire.Location = new System.Drawing.Point(208, 321);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(181, 58);
            this.btnFire.TabIndex = 4;
            this.btnFire.Text = "Fire Method";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.Maroon;
            this.lblFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblFileName.Location = new System.Drawing.Point(80, 222);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(172, 37);
            this.lblFileName.TabIndex = 5;
            this.lblFileName.Text = "Enter File Name";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(319, 222);
            this.txtFileName.Multiline = true;
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(230, 37);
            this.txtFileName.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 499);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtFileName;
    }
}

