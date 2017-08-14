namespace CryptoSteganoGui
{
    partial class ProgressForm
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
            this.progressLbl = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.processInfoLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(17, 99);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(64, 13);
            this.progressLbl.TabIndex = 7;
            this.progressLbl.Text = "progress [%]";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 56);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 30);
            this.progressBar1.TabIndex = 6;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(445, 125);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // processInfoLbl
            // 
            this.processInfoLbl.AutoSize = true;
            this.processInfoLbl.Location = new System.Drawing.Point(17, 20);
            this.processInfoLbl.Name = "processInfoLbl";
            this.processInfoLbl.Size = new System.Drawing.Size(65, 13);
            this.processInfoLbl.TabIndex = 9;
            this.processInfoLbl.Text = "Process info";
            // 
            // ProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 166);
            this.Controls.Add(this.processInfoLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.progressBar1);
            this.Name = "ProgressForm";
            this.Text = "ProgressForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label progressLbl;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label processInfoLbl;
    }
}