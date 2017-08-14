namespace CryptoSteganoGui
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
            this.menuPnl = new System.Windows.Forms.Panel();
            this.exitBtn = new System.Windows.Forms.Button();
            this.steganographyBtn = new System.Windows.Forms.Button();
            this.cryptoanalyserBtn = new System.Windows.Forms.Button();
            this.hillCipherBtn = new System.Windows.Forms.Button();
            this.affineCipherBtn = new System.Windows.Forms.Button();
            this.affineCipherPnl = new System.Windows.Forms.Panel();
            this.affineExecuteBtn = new System.Windows.Forms.Button();
            this.affineDecryptRb = new System.Windows.Forms.RadioButton();
            this.affineEncryptRb = new System.Windows.Forms.RadioButton();
            this.affineBackBtn = new System.Windows.Forms.Button();
            this.affineExitBtn = new System.Windows.Forms.Button();
            this.affineOutputDirectoryBrowseBtn = new System.Windows.Forms.Button();
            this.affineInputFileBrowseBtn = new System.Windows.Forms.Button();
            this.affineOutputDirectoryLbl = new System.Windows.Forms.Label();
            this.affineOutputDirectoryTb = new System.Windows.Forms.TextBox();
            this.affineInputFileLbl = new System.Windows.Forms.Label();
            this.affineInputFileTb = new System.Windows.Forms.TextBox();
            this.affineKeyGb = new System.Windows.Forms.GroupBox();
            this.affKeyCorectnessBtn = new System.Windows.Forms.Button();
            this.digramTb = new System.Windows.Forms.GroupBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.matrixGb = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuPnl.SuspendLayout();
            this.affineCipherPnl.SuspendLayout();
            this.affineKeyGb.SuspendLayout();
            this.digramTb.SuspendLayout();
            this.matrixGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPnl
            // 
            this.menuPnl.Controls.Add(this.exitBtn);
            this.menuPnl.Controls.Add(this.steganographyBtn);
            this.menuPnl.Controls.Add(this.cryptoanalyserBtn);
            this.menuPnl.Controls.Add(this.hillCipherBtn);
            this.menuPnl.Controls.Add(this.affineCipherBtn);
            this.menuPnl.Location = new System.Drawing.Point(12, 12);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(570, 470);
            this.menuPnl.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(104, 249);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // steganographyBtn
            // 
            this.steganographyBtn.Location = new System.Drawing.Point(104, 184);
            this.steganographyBtn.Name = "steganographyBtn";
            this.steganographyBtn.Size = new System.Drawing.Size(116, 23);
            this.steganographyBtn.TabIndex = 3;
            this.steganographyBtn.Text = "Steganography";
            this.steganographyBtn.UseVisualStyleBackColor = true;
            // 
            // cryptoanalyserBtn
            // 
            this.cryptoanalyserBtn.Location = new System.Drawing.Point(104, 145);
            this.cryptoanalyserBtn.Name = "cryptoanalyserBtn";
            this.cryptoanalyserBtn.Size = new System.Drawing.Size(116, 23);
            this.cryptoanalyserBtn.TabIndex = 2;
            this.cryptoanalyserBtn.Text = "Affine cryptoanalyser";
            this.cryptoanalyserBtn.UseVisualStyleBackColor = true;
            // 
            // hillCipherBtn
            // 
            this.hillCipherBtn.Location = new System.Drawing.Point(104, 86);
            this.hillCipherBtn.Name = "hillCipherBtn";
            this.hillCipherBtn.Size = new System.Drawing.Size(75, 23);
            this.hillCipherBtn.TabIndex = 1;
            this.hillCipherBtn.Text = "Hill cipher";
            this.hillCipherBtn.UseVisualStyleBackColor = true;
            // 
            // affineCipherBtn
            // 
            this.affineCipherBtn.Location = new System.Drawing.Point(104, 34);
            this.affineCipherBtn.Name = "affineCipherBtn";
            this.affineCipherBtn.Size = new System.Drawing.Size(75, 23);
            this.affineCipherBtn.TabIndex = 0;
            this.affineCipherBtn.Text = "Affine cipher";
            this.affineCipherBtn.UseVisualStyleBackColor = true;
            // 
            // affineCipherPnl
            // 
            this.affineCipherPnl.Controls.Add(this.affineExecuteBtn);
            this.affineCipherPnl.Controls.Add(this.affineDecryptRb);
            this.affineCipherPnl.Controls.Add(this.affineEncryptRb);
            this.affineCipherPnl.Controls.Add(this.affineBackBtn);
            this.affineCipherPnl.Controls.Add(this.affineExitBtn);
            this.affineCipherPnl.Controls.Add(this.affineOutputDirectoryBrowseBtn);
            this.affineCipherPnl.Controls.Add(this.affineInputFileBrowseBtn);
            this.affineCipherPnl.Controls.Add(this.affineOutputDirectoryLbl);
            this.affineCipherPnl.Controls.Add(this.affineOutputDirectoryTb);
            this.affineCipherPnl.Controls.Add(this.affineInputFileLbl);
            this.affineCipherPnl.Controls.Add(this.affineInputFileTb);
            this.affineCipherPnl.Controls.Add(this.affineKeyGb);
            this.affineCipherPnl.Location = new System.Drawing.Point(697, 46);
            this.affineCipherPnl.Name = "affineCipherPnl";
            this.affineCipherPnl.Size = new System.Drawing.Size(570, 470);
            this.affineCipherPnl.TabIndex = 1;
            // 
            // affineExecuteBtn
            // 
            this.affineExecuteBtn.Location = new System.Drawing.Point(305, 430);
            this.affineExecuteBtn.Name = "affineExecuteBtn";
            this.affineExecuteBtn.Size = new System.Drawing.Size(75, 23);
            this.affineExecuteBtn.TabIndex = 11;
            this.affineExecuteBtn.Text = "Execute";
            this.affineExecuteBtn.UseVisualStyleBackColor = true;
            // 
            // affineDecryptRb
            // 
            this.affineDecryptRb.AutoSize = true;
            this.affineDecryptRb.Location = new System.Drawing.Point(20, 370);
            this.affineDecryptRb.Name = "affineDecryptRb";
            this.affineDecryptRb.Size = new System.Drawing.Size(62, 17);
            this.affineDecryptRb.TabIndex = 10;
            this.affineDecryptRb.TabStop = true;
            this.affineDecryptRb.Text = "Decrypt";
            this.affineDecryptRb.UseVisualStyleBackColor = true;
            // 
            // affineEncryptRb
            // 
            this.affineEncryptRb.AutoSize = true;
            this.affineEncryptRb.Location = new System.Drawing.Point(20, 340);
            this.affineEncryptRb.Name = "affineEncryptRb";
            this.affineEncryptRb.Size = new System.Drawing.Size(61, 17);
            this.affineEncryptRb.TabIndex = 9;
            this.affineEncryptRb.TabStop = true;
            this.affineEncryptRb.Text = "Encrypt";
            this.affineEncryptRb.UseVisualStyleBackColor = true;
            // 
            // affineBackBtn
            // 
            this.affineBackBtn.Location = new System.Drawing.Point(390, 430);
            this.affineBackBtn.Name = "affineBackBtn";
            this.affineBackBtn.Size = new System.Drawing.Size(75, 23);
            this.affineBackBtn.TabIndex = 7;
            this.affineBackBtn.Text = "Back";
            this.affineBackBtn.UseVisualStyleBackColor = true;
            // 
            // affineExitBtn
            // 
            this.affineExitBtn.Location = new System.Drawing.Point(475, 430);
            this.affineExitBtn.Name = "affineExitBtn";
            this.affineExitBtn.Size = new System.Drawing.Size(75, 23);
            this.affineExitBtn.TabIndex = 6;
            this.affineExitBtn.Text = "Exit";
            this.affineExitBtn.UseVisualStyleBackColor = true;
            // 
            // affineOutputDirectoryBrowseBtn
            // 
            this.affineOutputDirectoryBrowseBtn.Location = new System.Drawing.Point(475, 298);
            this.affineOutputDirectoryBrowseBtn.Name = "affineOutputDirectoryBrowseBtn";
            this.affineOutputDirectoryBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.affineOutputDirectoryBrowseBtn.TabIndex = 3;
            this.affineOutputDirectoryBrowseBtn.Text = "Browse";
            this.affineOutputDirectoryBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // affineInputFileBrowseBtn
            // 
            this.affineInputFileBrowseBtn.Location = new System.Drawing.Point(475, 243);
            this.affineInputFileBrowseBtn.Name = "affineInputFileBrowseBtn";
            this.affineInputFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.affineInputFileBrowseBtn.TabIndex = 3;
            this.affineInputFileBrowseBtn.Text = "Browse";
            this.affineInputFileBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // affineOutputDirectoryLbl
            // 
            this.affineOutputDirectoryLbl.AutoSize = true;
            this.affineOutputDirectoryLbl.Location = new System.Drawing.Point(20, 280);
            this.affineOutputDirectoryLbl.Name = "affineOutputDirectoryLbl";
            this.affineOutputDirectoryLbl.Size = new System.Drawing.Size(163, 13);
            this.affineOutputDirectoryLbl.TabIndex = 2;
            this.affineOutputDirectoryLbl.Text = "Encryped/decrypted file location:";
            // 
            // affineOutputDirectoryTb
            // 
            this.affineOutputDirectoryTb.Location = new System.Drawing.Point(20, 300);
            this.affineOutputDirectoryTb.Name = "affineOutputDirectoryTb";
            this.affineOutputDirectoryTb.Size = new System.Drawing.Size(450, 20);
            this.affineOutputDirectoryTb.TabIndex = 1;
            // 
            // affineInputFileLbl
            // 
            this.affineInputFileLbl.AutoSize = true;
            this.affineInputFileLbl.Location = new System.Drawing.Point(20, 225);
            this.affineInputFileLbl.Name = "affineInputFileLbl";
            this.affineInputFileLbl.Size = new System.Drawing.Size(116, 13);
            this.affineInputFileLbl.TabIndex = 2;
            this.affineInputFileLbl.Text = "File to encrypt/decrypt:";
            // 
            // affineInputFileTb
            // 
            this.affineInputFileTb.Location = new System.Drawing.Point(20, 245);
            this.affineInputFileTb.Name = "affineInputFileTb";
            this.affineInputFileTb.Size = new System.Drawing.Size(450, 20);
            this.affineInputFileTb.TabIndex = 1;
            // 
            // affineKeyGb
            // 
            this.affineKeyGb.Controls.Add(this.affKeyCorectnessBtn);
            this.affineKeyGb.Controls.Add(this.digramTb);
            this.affineKeyGb.Controls.Add(this.matrixGb);
            this.affineKeyGb.Location = new System.Drawing.Point(20, 20);
            this.affineKeyGb.Name = "affineKeyGb";
            this.affineKeyGb.Size = new System.Drawing.Size(530, 170);
            this.affineKeyGb.TabIndex = 0;
            this.affineKeyGb.TabStop = false;
            this.affineKeyGb.Text = "Encrypt key";
            // 
            // affKeyCorectnessBtn
            // 
            this.affKeyCorectnessBtn.Location = new System.Drawing.Point(200, 130);
            this.affKeyCorectnessBtn.Name = "affKeyCorectnessBtn";
            this.affKeyCorectnessBtn.Size = new System.Drawing.Size(127, 23);
            this.affKeyCorectnessBtn.TabIndex = 2;
            this.affKeyCorectnessBtn.Text = "Check key correctness";
            this.affKeyCorectnessBtn.UseVisualStyleBackColor = true;
            // 
            // digramTb
            // 
            this.digramTb.Controls.Add(this.textBox7);
            this.digramTb.Controls.Add(this.textBox1);
            this.digramTb.Location = new System.Drawing.Point(265, 30);
            this.digramTb.Name = "digramTb";
            this.digramTb.Size = new System.Drawing.Size(245, 90);
            this.digramTb.TabIndex = 1;
            this.digramTb.TabStop = false;
            this.digramTb.Text = "Digram";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(125, 35);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // matrixGb
            // 
            this.matrixGb.Controls.Add(this.textBox6);
            this.matrixGb.Controls.Add(this.textBox4);
            this.matrixGb.Controls.Add(this.textBox5);
            this.matrixGb.Controls.Add(this.textBox3);
            this.matrixGb.Location = new System.Drawing.Point(19, 30);
            this.matrixGb.Name = "matrixGb";
            this.matrixGb.Size = new System.Drawing.Size(240, 90);
            this.matrixGb.TabIndex = 0;
            this.matrixGb.TabStop = false;
            this.matrixGb.Text = "Matrix";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(125, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(125, 25);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(15, 55);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(15, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 675);
            this.Controls.Add(this.affineCipherPnl);
            this.Controls.Add(this.menuPnl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuPnl.ResumeLayout(false);
            this.affineCipherPnl.ResumeLayout(false);
            this.affineCipherPnl.PerformLayout();
            this.affineKeyGb.ResumeLayout(false);
            this.digramTb.ResumeLayout(false);
            this.digramTb.PerformLayout();
            this.matrixGb.ResumeLayout(false);
            this.matrixGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.Button steganographyBtn;
        private System.Windows.Forms.Button cryptoanalyserBtn;
        private System.Windows.Forms.Button hillCipherBtn;
        private System.Windows.Forms.Button affineCipherBtn;
        private System.Windows.Forms.Panel affineCipherPnl;
        private System.Windows.Forms.RadioButton affineDecryptRb;
        private System.Windows.Forms.RadioButton affineEncryptRb;
        private System.Windows.Forms.Button affineBackBtn;
        private System.Windows.Forms.Button affineExitBtn;
        private System.Windows.Forms.Button affineOutputDirectoryBrowseBtn;
        private System.Windows.Forms.Button affineInputFileBrowseBtn;
        private System.Windows.Forms.Label affineOutputDirectoryLbl;
        private System.Windows.Forms.TextBox affineOutputDirectoryTb;
        private System.Windows.Forms.Label affineInputFileLbl;
        private System.Windows.Forms.TextBox affineInputFileTb;
        private System.Windows.Forms.GroupBox affineKeyGb;
        private System.Windows.Forms.Button affKeyCorectnessBtn;
        private System.Windows.Forms.GroupBox digramTb;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox matrixGb;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button affineExecuteBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

