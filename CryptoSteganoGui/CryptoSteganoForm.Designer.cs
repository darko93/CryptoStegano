namespace CryptoSteganoGui
{
    partial class CryptoSteganoForm
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
            this.hillCipherPnl = new System.Windows.Forms.Panel();
            this.hillExecuteBtn = new System.Windows.Forms.Button();
            this.hillDecryptRb = new System.Windows.Forms.RadioButton();
            this.hillEncryptRb = new System.Windows.Forms.RadioButton();
            this.hillBackBtn = new System.Windows.Forms.Button();
            this.hillExitBtn = new System.Windows.Forms.Button();
            this.hillOutputFileBrowseBtn = new System.Windows.Forms.Button();
            this.hillInputFileBrowseBtn = new System.Windows.Forms.Button();
            this.hillOutputFileLbl = new System.Windows.Forms.Label();
            this.hillOutputTb = new System.Windows.Forms.TextBox();
            this.hillInputFileLbl = new System.Windows.Forms.Label();
            this.hillInputFileTb = new System.Windows.Forms.TextBox();
            this.hillKeyGb = new System.Windows.Forms.GroupBox();
            this.hillKeyCorectnessBtn = new System.Windows.Forms.Button();
            this.digramTb = new System.Windows.Forms.GroupBox();
            this.hillKeyD1Tb = new System.Windows.Forms.TextBox();
            this.hillKeyD0Tb = new System.Windows.Forms.TextBox();
            this.matrixGb = new System.Windows.Forms.GroupBox();
            this.hillKeyA11Tb = new System.Windows.Forms.TextBox();
            this.hillKeyA01Tb = new System.Windows.Forms.TextBox();
            this.hillKeyA10Tb = new System.Windows.Forms.TextBox();
            this.hillKeyA00Tb = new System.Windows.Forms.TextBox();
            this.affineCipherPnl = new System.Windows.Forms.Panel();
            this.affineExecuteBtn = new System.Windows.Forms.Button();
            this.affineDecryptRb = new System.Windows.Forms.RadioButton();
            this.affineEncryptRb = new System.Windows.Forms.RadioButton();
            this.affineBackBtn = new System.Windows.Forms.Button();
            this.affineExitBtn = new System.Windows.Forms.Button();
            this.affineOutputFileBrowseBtn = new System.Windows.Forms.Button();
            this.affineInputFileBrowseBtn = new System.Windows.Forms.Button();
            this.affineOutputFileLbl = new System.Windows.Forms.Label();
            this.affineOutputFileTb = new System.Windows.Forms.TextBox();
            this.affineInputFileLbl = new System.Windows.Forms.Label();
            this.affineInputFileTb = new System.Windows.Forms.TextBox();
            this.affineKeyGb = new System.Windows.Forms.GroupBox();
            this.affineKeyATb = new System.Windows.Forms.TextBox();
            this.affineKeyBLbl = new System.Windows.Forms.Label();
            this.affineKeyALbl = new System.Windows.Forms.Label();
            this.affineKeyBTb = new System.Windows.Forms.TextBox();
            this.affineKeyCorrectnessBtn = new System.Windows.Forms.Button();
            this.steganoPnl = new System.Windows.Forms.Panel();
            this.steganoExecuteBtn = new System.Windows.Forms.Button();
            this.discoverMsgRb = new System.Windows.Forms.RadioButton();
            this.hideMsgRb = new System.Windows.Forms.RadioButton();
            this.steganoBackBtn = new System.Windows.Forms.Button();
            this.steganoExitBtn = new System.Windows.Forms.Button();
            this.outputCoverFileBrowseBtn = new System.Windows.Forms.Button();
            this.msgFileBrowseBtn = new System.Windows.Forms.Button();
            this.inputCoverFileBrowseBtn = new System.Windows.Forms.Button();
            this.outputCoverFileLbl = new System.Windows.Forms.Label();
            this.outputCoverFileTb = new System.Windows.Forms.TextBox();
            this.msgFileLbl = new System.Windows.Forms.Label();
            this.msgFileTb = new System.Windows.Forms.TextBox();
            this.inputCoverFileLbl = new System.Windows.Forms.Label();
            this.inputCoverFileTb = new System.Windows.Forms.TextBox();
            this.cryptoanalysisPnl = new System.Windows.Forms.Panel();
            this.cryptoanalysisExecuteBtn = new System.Windows.Forms.Button();
            this.cryptoanalysisBackBtn = new System.Windows.Forms.Button();
            this.cryptoanalysisExitBtn = new System.Windows.Forms.Button();
            this.decryptedOutputFileBtn = new System.Windows.Forms.Button();
            this.encryptedFileBrowseBtn = new System.Windows.Forms.Button();
            this.decryptedOutputFileLbl = new System.Windows.Forms.Label();
            this.decryptedOutputFileTb = new System.Windows.Forms.TextBox();
            this.encryptedFileLbl = new System.Windows.Forms.Label();
            this.encryptedFileTb = new System.Windows.Forms.TextBox();
            this.extensionsCb = new System.Windows.Forms.ComboBox();
            this.originalExtensionLbl = new System.Windows.Forms.Label();
            this.checkEncryptKeyBtn = new System.Windows.Forms.Button();
            this.addingExtensionWithSignatureGb = new System.Windows.Forms.GroupBox();
            this.newExtensionLbl = new System.Windows.Forms.Label();
            this.newExtensionTb = new System.Windows.Forms.TextBox();
            this.signatureBytesLbl = new System.Windows.Forms.Label();
            this.signatureBytesTb = new System.Windows.Forms.TextBox();
            this.addExtensionWithSignatureBtn = new System.Windows.Forms.Button();
            this.menuPnl.SuspendLayout();
            this.hillCipherPnl.SuspendLayout();
            this.hillKeyGb.SuspendLayout();
            this.digramTb.SuspendLayout();
            this.matrixGb.SuspendLayout();
            this.affineCipherPnl.SuspendLayout();
            this.affineKeyGb.SuspendLayout();
            this.steganoPnl.SuspendLayout();
            this.cryptoanalysisPnl.SuspendLayout();
            this.addingExtensionWithSignatureGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPnl
            // 
            this.menuPnl.Controls.Add(this.steganoPnl);
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
            this.exitBtn.Location = new System.Drawing.Point(220, 340);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(120, 23);
            this.exitBtn.TabIndex = 4;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // steganographyBtn
            // 
            this.steganographyBtn.Location = new System.Drawing.Point(220, 250);
            this.steganographyBtn.Name = "steganographyBtn";
            this.steganographyBtn.Size = new System.Drawing.Size(120, 23);
            this.steganographyBtn.TabIndex = 3;
            this.steganographyBtn.Text = "Steganography";
            this.steganographyBtn.UseVisualStyleBackColor = true;
            // 
            // cryptoanalyserBtn
            // 
            this.cryptoanalyserBtn.Location = new System.Drawing.Point(220, 195);
            this.cryptoanalyserBtn.Name = "cryptoanalyserBtn";
            this.cryptoanalyserBtn.Size = new System.Drawing.Size(120, 23);
            this.cryptoanalyserBtn.TabIndex = 2;
            this.cryptoanalyserBtn.Text = "Affine cryptoanalysis";
            this.cryptoanalyserBtn.UseVisualStyleBackColor = true;
            // 
            // hillCipherBtn
            // 
            this.hillCipherBtn.Location = new System.Drawing.Point(220, 140);
            this.hillCipherBtn.Name = "hillCipherBtn";
            this.hillCipherBtn.Size = new System.Drawing.Size(120, 23);
            this.hillCipherBtn.TabIndex = 1;
            this.hillCipherBtn.Text = "Hill cipher";
            this.hillCipherBtn.UseVisualStyleBackColor = true;
            // 
            // affineCipherBtn
            // 
            this.affineCipherBtn.Location = new System.Drawing.Point(220, 85);
            this.affineCipherBtn.Name = "affineCipherBtn";
            this.affineCipherBtn.Size = new System.Drawing.Size(120, 23);
            this.affineCipherBtn.TabIndex = 0;
            this.affineCipherBtn.Text = "Affine cipher";
            this.affineCipherBtn.UseVisualStyleBackColor = true;
            // 
            // hillCipherPnl
            // 
            this.hillCipherPnl.Controls.Add(this.hillExecuteBtn);
            this.hillCipherPnl.Controls.Add(this.hillDecryptRb);
            this.hillCipherPnl.Controls.Add(this.hillEncryptRb);
            this.hillCipherPnl.Controls.Add(this.hillBackBtn);
            this.hillCipherPnl.Controls.Add(this.hillExitBtn);
            this.hillCipherPnl.Controls.Add(this.hillOutputFileBrowseBtn);
            this.hillCipherPnl.Controls.Add(this.hillInputFileBrowseBtn);
            this.hillCipherPnl.Controls.Add(this.hillOutputFileLbl);
            this.hillCipherPnl.Controls.Add(this.hillOutputTb);
            this.hillCipherPnl.Controls.Add(this.hillInputFileLbl);
            this.hillCipherPnl.Controls.Add(this.hillInputFileTb);
            this.hillCipherPnl.Controls.Add(this.hillKeyGb);
            this.hillCipherPnl.Location = new System.Drawing.Point(605, 508);
            this.hillCipherPnl.Name = "hillCipherPnl";
            this.hillCipherPnl.Size = new System.Drawing.Size(570, 470);
            this.hillCipherPnl.TabIndex = 1;
            // 
            // hillExecuteBtn
            // 
            this.hillExecuteBtn.Location = new System.Drawing.Point(305, 430);
            this.hillExecuteBtn.Name = "hillExecuteBtn";
            this.hillExecuteBtn.Size = new System.Drawing.Size(75, 23);
            this.hillExecuteBtn.TabIndex = 11;
            this.hillExecuteBtn.Text = "Execute";
            this.hillExecuteBtn.UseVisualStyleBackColor = true;
            // 
            // hillDecryptRb
            // 
            this.hillDecryptRb.AutoSize = true;
            this.hillDecryptRb.Location = new System.Drawing.Point(20, 370);
            this.hillDecryptRb.Name = "hillDecryptRb";
            this.hillDecryptRb.Size = new System.Drawing.Size(62, 17);
            this.hillDecryptRb.TabIndex = 10;
            this.hillDecryptRb.TabStop = true;
            this.hillDecryptRb.Text = "Decrypt";
            this.hillDecryptRb.UseVisualStyleBackColor = true;
            // 
            // hillEncryptRb
            // 
            this.hillEncryptRb.AutoSize = true;
            this.hillEncryptRb.Location = new System.Drawing.Point(20, 340);
            this.hillEncryptRb.Name = "hillEncryptRb";
            this.hillEncryptRb.Size = new System.Drawing.Size(61, 17);
            this.hillEncryptRb.TabIndex = 9;
            this.hillEncryptRb.TabStop = true;
            this.hillEncryptRb.Text = "Encrypt";
            this.hillEncryptRb.UseVisualStyleBackColor = true;
            // 
            // hillBackBtn
            // 
            this.hillBackBtn.Location = new System.Drawing.Point(390, 430);
            this.hillBackBtn.Name = "hillBackBtn";
            this.hillBackBtn.Size = new System.Drawing.Size(75, 23);
            this.hillBackBtn.TabIndex = 7;
            this.hillBackBtn.Text = "Back";
            this.hillBackBtn.UseVisualStyleBackColor = true;
            // 
            // hillExitBtn
            // 
            this.hillExitBtn.Location = new System.Drawing.Point(475, 430);
            this.hillExitBtn.Name = "hillExitBtn";
            this.hillExitBtn.Size = new System.Drawing.Size(75, 23);
            this.hillExitBtn.TabIndex = 6;
            this.hillExitBtn.Text = "Exit";
            this.hillExitBtn.UseVisualStyleBackColor = true;
            // 
            // hillOutputFileBrowseBtn
            // 
            this.hillOutputFileBrowseBtn.Location = new System.Drawing.Point(475, 298);
            this.hillOutputFileBrowseBtn.Name = "hillOutputFileBrowseBtn";
            this.hillOutputFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.hillOutputFileBrowseBtn.TabIndex = 3;
            this.hillOutputFileBrowseBtn.Text = "Browse";
            this.hillOutputFileBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // hillInputFileBrowseBtn
            // 
            this.hillInputFileBrowseBtn.Location = new System.Drawing.Point(475, 243);
            this.hillInputFileBrowseBtn.Name = "hillInputFileBrowseBtn";
            this.hillInputFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.hillInputFileBrowseBtn.TabIndex = 3;
            this.hillInputFileBrowseBtn.Text = "Browse";
            this.hillInputFileBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // hillOutputFileLbl
            // 
            this.hillOutputFileLbl.AutoSize = true;
            this.hillOutputFileLbl.Location = new System.Drawing.Point(20, 280);
            this.hillOutputFileLbl.Name = "hillOutputFileLbl";
            this.hillOutputFileLbl.Size = new System.Drawing.Size(247, 13);
            this.hillOutputFileLbl.TabIndex = 2;
            this.hillOutputFileLbl.Text = "Encryped/decrypted output file (without extension):";
            // 
            // hillOutputTb
            // 
            this.hillOutputTb.Location = new System.Drawing.Point(20, 300);
            this.hillOutputTb.Name = "hillOutputTb";
            this.hillOutputTb.Size = new System.Drawing.Size(450, 20);
            this.hillOutputTb.TabIndex = 1;
            // 
            // hillInputFileLbl
            // 
            this.hillInputFileLbl.AutoSize = true;
            this.hillInputFileLbl.Location = new System.Drawing.Point(20, 225);
            this.hillInputFileLbl.Name = "hillInputFileLbl";
            this.hillInputFileLbl.Size = new System.Drawing.Size(116, 13);
            this.hillInputFileLbl.TabIndex = 2;
            this.hillInputFileLbl.Text = "File to encrypt/decrypt:";
            // 
            // hillInputFileTb
            // 
            this.hillInputFileTb.Location = new System.Drawing.Point(20, 245);
            this.hillInputFileTb.Name = "hillInputFileTb";
            this.hillInputFileTb.Size = new System.Drawing.Size(450, 20);
            this.hillInputFileTb.TabIndex = 1;
            // 
            // hillKeyGb
            // 
            this.hillKeyGb.Controls.Add(this.hillKeyCorectnessBtn);
            this.hillKeyGb.Controls.Add(this.digramTb);
            this.hillKeyGb.Controls.Add(this.matrixGb);
            this.hillKeyGb.Location = new System.Drawing.Point(20, 20);
            this.hillKeyGb.Name = "hillKeyGb";
            this.hillKeyGb.Size = new System.Drawing.Size(530, 170);
            this.hillKeyGb.TabIndex = 0;
            this.hillKeyGb.TabStop = false;
            this.hillKeyGb.Text = "Encrypt key";
            // 
            // hillKeyCorectnessBtn
            // 
            this.hillKeyCorectnessBtn.Location = new System.Drawing.Point(200, 130);
            this.hillKeyCorectnessBtn.Name = "hillKeyCorectnessBtn";
            this.hillKeyCorectnessBtn.Size = new System.Drawing.Size(127, 23);
            this.hillKeyCorectnessBtn.TabIndex = 2;
            this.hillKeyCorectnessBtn.Text = "Check key correctness";
            this.hillKeyCorectnessBtn.UseVisualStyleBackColor = true;
            // 
            // digramTb
            // 
            this.digramTb.Controls.Add(this.hillKeyD1Tb);
            this.digramTb.Controls.Add(this.hillKeyD0Tb);
            this.digramTb.Location = new System.Drawing.Point(265, 30);
            this.digramTb.Name = "digramTb";
            this.digramTb.Size = new System.Drawing.Size(245, 90);
            this.digramTb.TabIndex = 1;
            this.digramTb.TabStop = false;
            this.digramTb.Text = "Digram";
            // 
            // hillKeyD1Tb
            // 
            this.hillKeyD1Tb.Location = new System.Drawing.Point(125, 35);
            this.hillKeyD1Tb.Name = "hillKeyD1Tb";
            this.hillKeyD1Tb.Size = new System.Drawing.Size(100, 20);
            this.hillKeyD1Tb.TabIndex = 1;
            // 
            // hillKeyD0Tb
            // 
            this.hillKeyD0Tb.Location = new System.Drawing.Point(15, 35);
            this.hillKeyD0Tb.Name = "hillKeyD0Tb";
            this.hillKeyD0Tb.Size = new System.Drawing.Size(100, 20);
            this.hillKeyD0Tb.TabIndex = 0;
            // 
            // matrixGb
            // 
            this.matrixGb.Controls.Add(this.hillKeyA11Tb);
            this.matrixGb.Controls.Add(this.hillKeyA01Tb);
            this.matrixGb.Controls.Add(this.hillKeyA10Tb);
            this.matrixGb.Controls.Add(this.hillKeyA00Tb);
            this.matrixGb.Location = new System.Drawing.Point(19, 30);
            this.matrixGb.Name = "matrixGb";
            this.matrixGb.Size = new System.Drawing.Size(240, 90);
            this.matrixGb.TabIndex = 0;
            this.matrixGb.TabStop = false;
            this.matrixGb.Text = "Matrix";
            // 
            // hillKeyA11Tb
            // 
            this.hillKeyA11Tb.Location = new System.Drawing.Point(125, 55);
            this.hillKeyA11Tb.Name = "hillKeyA11Tb";
            this.hillKeyA11Tb.Size = new System.Drawing.Size(100, 20);
            this.hillKeyA11Tb.TabIndex = 0;
            // 
            // hillKeyA01Tb
            // 
            this.hillKeyA01Tb.Location = new System.Drawing.Point(125, 25);
            this.hillKeyA01Tb.Name = "hillKeyA01Tb";
            this.hillKeyA01Tb.Size = new System.Drawing.Size(100, 20);
            this.hillKeyA01Tb.TabIndex = 0;
            // 
            // hillKeyA10Tb
            // 
            this.hillKeyA10Tb.Location = new System.Drawing.Point(15, 55);
            this.hillKeyA10Tb.Name = "hillKeyA10Tb";
            this.hillKeyA10Tb.Size = new System.Drawing.Size(100, 20);
            this.hillKeyA10Tb.TabIndex = 0;
            // 
            // hillKeyA00Tb
            // 
            this.hillKeyA00Tb.Location = new System.Drawing.Point(15, 25);
            this.hillKeyA00Tb.Name = "hillKeyA00Tb";
            this.hillKeyA00Tb.Size = new System.Drawing.Size(100, 20);
            this.hillKeyA00Tb.TabIndex = 0;
            // 
            // affineCipherPnl
            // 
            this.affineCipherPnl.Controls.Add(this.affineExecuteBtn);
            this.affineCipherPnl.Controls.Add(this.affineDecryptRb);
            this.affineCipherPnl.Controls.Add(this.affineEncryptRb);
            this.affineCipherPnl.Controls.Add(this.affineBackBtn);
            this.affineCipherPnl.Controls.Add(this.affineExitBtn);
            this.affineCipherPnl.Controls.Add(this.affineOutputFileBrowseBtn);
            this.affineCipherPnl.Controls.Add(this.affineInputFileBrowseBtn);
            this.affineCipherPnl.Controls.Add(this.affineOutputFileLbl);
            this.affineCipherPnl.Controls.Add(this.affineOutputFileTb);
            this.affineCipherPnl.Controls.Add(this.affineInputFileLbl);
            this.affineCipherPnl.Controls.Add(this.affineInputFileTb);
            this.affineCipherPnl.Controls.Add(this.affineKeyGb);
            this.affineCipherPnl.Location = new System.Drawing.Point(12, 508);
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
            // affineOutputFileBrowseBtn
            // 
            this.affineOutputFileBrowseBtn.Location = new System.Drawing.Point(475, 298);
            this.affineOutputFileBrowseBtn.Name = "affineOutputFileBrowseBtn";
            this.affineOutputFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.affineOutputFileBrowseBtn.TabIndex = 3;
            this.affineOutputFileBrowseBtn.Text = "Browse";
            this.affineOutputFileBrowseBtn.UseVisualStyleBackColor = true;
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
            // affineOutputFileLbl
            // 
            this.affineOutputFileLbl.AutoSize = true;
            this.affineOutputFileLbl.Location = new System.Drawing.Point(20, 280);
            this.affineOutputFileLbl.Name = "affineOutputFileLbl";
            this.affineOutputFileLbl.Size = new System.Drawing.Size(247, 13);
            this.affineOutputFileLbl.TabIndex = 2;
            this.affineOutputFileLbl.Text = "Encryped/decrypted output file (without extension):";
            // 
            // affineOutputFileTb
            // 
            this.affineOutputFileTb.Location = new System.Drawing.Point(20, 300);
            this.affineOutputFileTb.Name = "affineOutputFileTb";
            this.affineOutputFileTb.Size = new System.Drawing.Size(450, 20);
            this.affineOutputFileTb.TabIndex = 1;
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
            this.affineKeyGb.Controls.Add(this.affineKeyATb);
            this.affineKeyGb.Controls.Add(this.affineKeyBLbl);
            this.affineKeyGb.Controls.Add(this.affineKeyALbl);
            this.affineKeyGb.Controls.Add(this.affineKeyBTb);
            this.affineKeyGb.Controls.Add(this.affineKeyCorrectnessBtn);
            this.affineKeyGb.Location = new System.Drawing.Point(20, 20);
            this.affineKeyGb.Name = "affineKeyGb";
            this.affineKeyGb.Size = new System.Drawing.Size(530, 170);
            this.affineKeyGb.TabIndex = 0;
            this.affineKeyGb.TabStop = false;
            this.affineKeyGb.Text = "Encrypt key";
            // 
            // affineKeyATb
            // 
            this.affineKeyATb.Location = new System.Drawing.Point(135, 55);
            this.affineKeyATb.Name = "affineKeyATb";
            this.affineKeyATb.Size = new System.Drawing.Size(100, 20);
            this.affineKeyATb.TabIndex = 0;
            // 
            // affineKeyBLbl
            // 
            this.affineKeyBLbl.AutoSize = true;
            this.affineKeyBLbl.Location = new System.Drawing.Point(275, 58);
            this.affineKeyBLbl.Name = "affineKeyBLbl";
            this.affineKeyBLbl.Size = new System.Drawing.Size(23, 13);
            this.affineKeyBLbl.TabIndex = 3;
            this.affineKeyBLbl.Text = "B =";
            // 
            // affineKeyALbl
            // 
            this.affineKeyALbl.AutoSize = true;
            this.affineKeyALbl.Location = new System.Drawing.Point(110, 58);
            this.affineKeyALbl.Name = "affineKeyALbl";
            this.affineKeyALbl.Size = new System.Drawing.Size(26, 13);
            this.affineKeyALbl.TabIndex = 3;
            this.affineKeyALbl.Text = "A = ";
            // 
            // affineKeyBTb
            // 
            this.affineKeyBTb.Location = new System.Drawing.Point(300, 55);
            this.affineKeyBTb.Name = "affineKeyBTb";
            this.affineKeyBTb.Size = new System.Drawing.Size(100, 20);
            this.affineKeyBTb.TabIndex = 1;
            // 
            // affineKeyCorrectnessBtn
            // 
            this.affineKeyCorrectnessBtn.Location = new System.Drawing.Point(200, 130);
            this.affineKeyCorrectnessBtn.Name = "affineKeyCorrectnessBtn";
            this.affineKeyCorrectnessBtn.Size = new System.Drawing.Size(127, 23);
            this.affineKeyCorrectnessBtn.TabIndex = 2;
            this.affineKeyCorrectnessBtn.Text = "Check key correctness";
            this.affineKeyCorrectnessBtn.UseVisualStyleBackColor = true;
            // 
            // steganoPnl
            // 
            this.steganoPnl.Controls.Add(this.steganoExecuteBtn);
            this.steganoPnl.Controls.Add(this.discoverMsgRb);
            this.steganoPnl.Controls.Add(this.hideMsgRb);
            this.steganoPnl.Controls.Add(this.steganoBackBtn);
            this.steganoPnl.Controls.Add(this.steganoExitBtn);
            this.steganoPnl.Controls.Add(this.outputCoverFileBrowseBtn);
            this.steganoPnl.Controls.Add(this.msgFileBrowseBtn);
            this.steganoPnl.Controls.Add(this.inputCoverFileBrowseBtn);
            this.steganoPnl.Controls.Add(this.outputCoverFileLbl);
            this.steganoPnl.Controls.Add(this.outputCoverFileTb);
            this.steganoPnl.Controls.Add(this.msgFileLbl);
            this.steganoPnl.Controls.Add(this.msgFileTb);
            this.steganoPnl.Controls.Add(this.inputCoverFileLbl);
            this.steganoPnl.Controls.Add(this.inputCoverFileTb);
            this.steganoPnl.Location = new System.Drawing.Point(39, 22);
            this.steganoPnl.Name = "steganoPnl";
            this.steganoPnl.Size = new System.Drawing.Size(570, 470);
            this.steganoPnl.TabIndex = 1;
            // 
            // steganoExecuteBtn
            // 
            this.steganoExecuteBtn.Location = new System.Drawing.Point(305, 430);
            this.steganoExecuteBtn.Name = "steganoExecuteBtn";
            this.steganoExecuteBtn.Size = new System.Drawing.Size(75, 23);
            this.steganoExecuteBtn.TabIndex = 11;
            this.steganoExecuteBtn.Text = "Execute";
            this.steganoExecuteBtn.UseVisualStyleBackColor = true;
            // 
            // discoverMsgRb
            // 
            this.discoverMsgRb.AutoSize = true;
            this.discoverMsgRb.Location = new System.Drawing.Point(268, 85);
            this.discoverMsgRb.Name = "discoverMsgRb";
            this.discoverMsgRb.Size = new System.Drawing.Size(112, 17);
            this.discoverMsgRb.TabIndex = 10;
            this.discoverMsgRb.TabStop = true;
            this.discoverMsgRb.Text = "Discover message";
            this.discoverMsgRb.UseVisualStyleBackColor = true;
            // 
            // hideMsgRb
            // 
            this.hideMsgRb.AutoSize = true;
            this.hideMsgRb.Location = new System.Drawing.Point(20, 85);
            this.hideMsgRb.Name = "hideMsgRb";
            this.hideMsgRb.Size = new System.Drawing.Size(92, 17);
            this.hideMsgRb.TabIndex = 9;
            this.hideMsgRb.TabStop = true;
            this.hideMsgRb.Text = "Hide message";
            this.hideMsgRb.UseVisualStyleBackColor = true;
            // 
            // steganoBackBtn
            // 
            this.steganoBackBtn.Location = new System.Drawing.Point(390, 430);
            this.steganoBackBtn.Name = "steganoBackBtn";
            this.steganoBackBtn.Size = new System.Drawing.Size(75, 23);
            this.steganoBackBtn.TabIndex = 7;
            this.steganoBackBtn.Text = "Back";
            this.steganoBackBtn.UseVisualStyleBackColor = true;
            // 
            // steganoExitBtn
            // 
            this.steganoExitBtn.Location = new System.Drawing.Point(475, 430);
            this.steganoExitBtn.Name = "steganoExitBtn";
            this.steganoExitBtn.Size = new System.Drawing.Size(75, 23);
            this.steganoExitBtn.TabIndex = 6;
            this.steganoExitBtn.Text = "Exit";
            this.steganoExitBtn.UseVisualStyleBackColor = true;
            // 
            // outputCoverFileBrowseBtn
            // 
            this.outputCoverFileBrowseBtn.Location = new System.Drawing.Point(475, 273);
            this.outputCoverFileBrowseBtn.Name = "outputCoverFileBrowseBtn";
            this.outputCoverFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.outputCoverFileBrowseBtn.TabIndex = 3;
            this.outputCoverFileBrowseBtn.Text = "Browse";
            this.outputCoverFileBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // msgFileBrowseBtn
            // 
            this.msgFileBrowseBtn.Location = new System.Drawing.Point(475, 218);
            this.msgFileBrowseBtn.Name = "msgFileBrowseBtn";
            this.msgFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.msgFileBrowseBtn.TabIndex = 3;
            this.msgFileBrowseBtn.Text = "Browse";
            this.msgFileBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // inputCoverFileBrowseBtn
            // 
            this.inputCoverFileBrowseBtn.Location = new System.Drawing.Point(475, 163);
            this.inputCoverFileBrowseBtn.Name = "inputCoverFileBrowseBtn";
            this.inputCoverFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.inputCoverFileBrowseBtn.TabIndex = 3;
            this.inputCoverFileBrowseBtn.Text = "Browse";
            this.inputCoverFileBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // outputCoverFileLbl
            // 
            this.outputCoverFileLbl.AutoSize = true;
            this.outputCoverFileLbl.Location = new System.Drawing.Point(20, 255);
            this.outputCoverFileLbl.Name = "outputCoverFileLbl";
            this.outputCoverFileLbl.Size = new System.Drawing.Size(88, 13);
            this.outputCoverFileLbl.TabIndex = 2;
            this.outputCoverFileLbl.Text = "Output cover file:";
            // 
            // outputCoverFileTb
            // 
            this.outputCoverFileTb.Location = new System.Drawing.Point(20, 275);
            this.outputCoverFileTb.Name = "outputCoverFileTb";
            this.outputCoverFileTb.Size = new System.Drawing.Size(450, 20);
            this.outputCoverFileTb.TabIndex = 1;
            // 
            // msgFileLbl
            // 
            this.msgFileLbl.AutoSize = true;
            this.msgFileLbl.Location = new System.Drawing.Point(20, 200);
            this.msgFileLbl.Name = "msgFileLbl";
            this.msgFileLbl.Size = new System.Drawing.Size(69, 13);
            this.msgFileLbl.TabIndex = 2;
            this.msgFileLbl.Text = "Message file:";
            // 
            // msgFileTb
            // 
            this.msgFileTb.Location = new System.Drawing.Point(20, 220);
            this.msgFileTb.Name = "msgFileTb";
            this.msgFileTb.Size = new System.Drawing.Size(450, 20);
            this.msgFileTb.TabIndex = 1;
            // 
            // inputCoverFileLbl
            // 
            this.inputCoverFileLbl.AutoSize = true;
            this.inputCoverFileLbl.Location = new System.Drawing.Point(20, 145);
            this.inputCoverFileLbl.Name = "inputCoverFileLbl";
            this.inputCoverFileLbl.Size = new System.Drawing.Size(80, 13);
            this.inputCoverFileLbl.TabIndex = 2;
            this.inputCoverFileLbl.Text = "Input cover file:";
            // 
            // inputCoverFileTb
            // 
            this.inputCoverFileTb.Location = new System.Drawing.Point(20, 165);
            this.inputCoverFileTb.Name = "inputCoverFileTb";
            this.inputCoverFileTb.Size = new System.Drawing.Size(450, 20);
            this.inputCoverFileTb.TabIndex = 1;
            // 
            // cryptoanalysisPnl
            // 
            this.cryptoanalysisPnl.Controls.Add(this.addingExtensionWithSignatureGb);
            this.cryptoanalysisPnl.Controls.Add(this.checkEncryptKeyBtn);
            this.cryptoanalysisPnl.Controls.Add(this.originalExtensionLbl);
            this.cryptoanalysisPnl.Controls.Add(this.extensionsCb);
            this.cryptoanalysisPnl.Controls.Add(this.cryptoanalysisExecuteBtn);
            this.cryptoanalysisPnl.Controls.Add(this.cryptoanalysisBackBtn);
            this.cryptoanalysisPnl.Controls.Add(this.cryptoanalysisExitBtn);
            this.cryptoanalysisPnl.Controls.Add(this.decryptedOutputFileBtn);
            this.cryptoanalysisPnl.Controls.Add(this.encryptedFileBrowseBtn);
            this.cryptoanalysisPnl.Controls.Add(this.decryptedOutputFileLbl);
            this.cryptoanalysisPnl.Controls.Add(this.decryptedOutputFileTb);
            this.cryptoanalysisPnl.Controls.Add(this.encryptedFileLbl);
            this.cryptoanalysisPnl.Controls.Add(this.encryptedFileTb);
            this.cryptoanalysisPnl.Location = new System.Drawing.Point(715, 15);
            this.cryptoanalysisPnl.Name = "cryptoanalysisPnl";
            this.cryptoanalysisPnl.Size = new System.Drawing.Size(570, 470);
            this.cryptoanalysisPnl.TabIndex = 1;
            // 
            // cryptoanalysisExecuteBtn
            // 
            this.cryptoanalysisExecuteBtn.Location = new System.Drawing.Point(305, 430);
            this.cryptoanalysisExecuteBtn.Name = "cryptoanalysisExecuteBtn";
            this.cryptoanalysisExecuteBtn.Size = new System.Drawing.Size(75, 23);
            this.cryptoanalysisExecuteBtn.TabIndex = 11;
            this.cryptoanalysisExecuteBtn.Text = "Execute";
            this.cryptoanalysisExecuteBtn.UseVisualStyleBackColor = true;
            // 
            // cryptoanalysisBackBtn
            // 
            this.cryptoanalysisBackBtn.Location = new System.Drawing.Point(390, 430);
            this.cryptoanalysisBackBtn.Name = "cryptoanalysisBackBtn";
            this.cryptoanalysisBackBtn.Size = new System.Drawing.Size(75, 23);
            this.cryptoanalysisBackBtn.TabIndex = 7;
            this.cryptoanalysisBackBtn.Text = "Back";
            this.cryptoanalysisBackBtn.UseVisualStyleBackColor = true;
            // 
            // cryptoanalysisExitBtn
            // 
            this.cryptoanalysisExitBtn.Location = new System.Drawing.Point(475, 430);
            this.cryptoanalysisExitBtn.Name = "cryptoanalysisExitBtn";
            this.cryptoanalysisExitBtn.Size = new System.Drawing.Size(75, 23);
            this.cryptoanalysisExitBtn.TabIndex = 6;
            this.cryptoanalysisExitBtn.Text = "Exit";
            this.cryptoanalysisExitBtn.UseVisualStyleBackColor = true;
            // 
            // decryptedOutputFileBtn
            // 
            this.decryptedOutputFileBtn.Location = new System.Drawing.Point(472, 301);
            this.decryptedOutputFileBtn.Name = "decryptedOutputFileBtn";
            this.decryptedOutputFileBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptedOutputFileBtn.TabIndex = 3;
            this.decryptedOutputFileBtn.Text = "Browse";
            this.decryptedOutputFileBtn.UseVisualStyleBackColor = true;
            // 
            // encryptedFileBrowseBtn
            // 
            this.encryptedFileBrowseBtn.Location = new System.Drawing.Point(472, 246);
            this.encryptedFileBrowseBtn.Name = "encryptedFileBrowseBtn";
            this.encryptedFileBrowseBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptedFileBrowseBtn.TabIndex = 3;
            this.encryptedFileBrowseBtn.Text = "Browse";
            this.encryptedFileBrowseBtn.UseVisualStyleBackColor = true;
            // 
            // decryptedOutputFileLbl
            // 
            this.decryptedOutputFileLbl.AutoSize = true;
            this.decryptedOutputFileLbl.Location = new System.Drawing.Point(17, 283);
            this.decryptedOutputFileLbl.Name = "decryptedOutputFileLbl";
            this.decryptedOutputFileLbl.Size = new System.Drawing.Size(199, 13);
            this.decryptedOutputFileLbl.TabIndex = 2;
            this.decryptedOutputFileLbl.Text = "Decrypted output file (without extension):";
            // 
            // decryptedOutputFileTb
            // 
            this.decryptedOutputFileTb.Location = new System.Drawing.Point(17, 303);
            this.decryptedOutputFileTb.Name = "decryptedOutputFileTb";
            this.decryptedOutputFileTb.Size = new System.Drawing.Size(450, 20);
            this.decryptedOutputFileTb.TabIndex = 1;
            // 
            // encryptedFileLbl
            // 
            this.encryptedFileLbl.AutoSize = true;
            this.encryptedFileLbl.Location = new System.Drawing.Point(17, 228);
            this.encryptedFileLbl.Name = "encryptedFileLbl";
            this.encryptedFileLbl.Size = new System.Drawing.Size(74, 13);
            this.encryptedFileLbl.TabIndex = 2;
            this.encryptedFileLbl.Text = "Encrypted file:";
            // 
            // encryptedFileTb
            // 
            this.encryptedFileTb.Location = new System.Drawing.Point(17, 248);
            this.encryptedFileTb.Name = "encryptedFileTb";
            this.encryptedFileTb.Size = new System.Drawing.Size(450, 20);
            this.encryptedFileTb.TabIndex = 1;
            // 
            // extensionsCb
            // 
            this.extensionsCb.FormattingEnabled = true;
            this.extensionsCb.Location = new System.Drawing.Point(17, 194);
            this.extensionsCb.Name = "extensionsCb";
            this.extensionsCb.Size = new System.Drawing.Size(121, 21);
            this.extensionsCb.TabIndex = 12;
            // 
            // originalExtensionLbl
            // 
            this.originalExtensionLbl.AutoSize = true;
            this.originalExtensionLbl.Location = new System.Drawing.Point(20, 175);
            this.originalExtensionLbl.Name = "originalExtensionLbl";
            this.originalExtensionLbl.Size = new System.Drawing.Size(109, 13);
            this.originalExtensionLbl.TabIndex = 13;
            this.originalExtensionLbl.Text = "Original file extension:";
            // 
            // checkEncryptKeyBtn
            // 
            this.checkEncryptKeyBtn.Location = new System.Drawing.Point(190, 430);
            this.checkEncryptKeyBtn.Name = "checkEncryptKeyBtn";
            this.checkEncryptKeyBtn.Size = new System.Drawing.Size(105, 23);
            this.checkEncryptKeyBtn.TabIndex = 14;
            this.checkEncryptKeyBtn.Text = "Check encrypt key";
            this.checkEncryptKeyBtn.UseVisualStyleBackColor = true;
            // 
            // addingExtensionWithSignatureGb
            // 
            this.addingExtensionWithSignatureGb.Controls.Add(this.addExtensionWithSignatureBtn);
            this.addingExtensionWithSignatureGb.Controls.Add(this.signatureBytesTb);
            this.addingExtensionWithSignatureGb.Controls.Add(this.newExtensionTb);
            this.addingExtensionWithSignatureGb.Controls.Add(this.signatureBytesLbl);
            this.addingExtensionWithSignatureGb.Controls.Add(this.newExtensionLbl);
            this.addingExtensionWithSignatureGb.Location = new System.Drawing.Point(20, 19);
            this.addingExtensionWithSignatureGb.Name = "addingExtensionWithSignatureGb";
            this.addingExtensionWithSignatureGb.Size = new System.Drawing.Size(530, 124);
            this.addingExtensionWithSignatureGb.TabIndex = 15;
            this.addingExtensionWithSignatureGb.TabStop = false;
            this.addingExtensionWithSignatureGb.Text = "Adding supported extension with signature";
            // 
            // newExtensionLbl
            // 
            this.newExtensionLbl.AutoSize = true;
            this.newExtensionLbl.Location = new System.Drawing.Point(20, 40);
            this.newExtensionLbl.Name = "newExtensionLbl";
            this.newExtensionLbl.Size = new System.Drawing.Size(56, 13);
            this.newExtensionLbl.TabIndex = 0;
            this.newExtensionLbl.Text = "Extension:";
            // 
            // newExtensionTb
            // 
            this.newExtensionTb.Location = new System.Drawing.Point(20, 60);
            this.newExtensionTb.Name = "newExtensionTb";
            this.newExtensionTb.Size = new System.Drawing.Size(100, 20);
            this.newExtensionTb.TabIndex = 1;
            // 
            // signatureBytesLbl
            // 
            this.signatureBytesLbl.AutoSize = true;
            this.signatureBytesLbl.Location = new System.Drawing.Point(160, 40);
            this.signatureBytesLbl.Name = "signatureBytesLbl";
            this.signatureBytesLbl.Size = new System.Drawing.Size(240, 13);
            this.signatureBytesLbl.TabIndex = 0;
            this.signatureBytesLbl.Text = "Hex signature bytes (use semicolon as separator):";
            // 
            // signatureBytesTb
            // 
            this.signatureBytesTb.Location = new System.Drawing.Point(160, 60);
            this.signatureBytesTb.Name = "signatureBytesTb";
            this.signatureBytesTb.Size = new System.Drawing.Size(100, 20);
            this.signatureBytesTb.TabIndex = 1;
            // 
            // addExtensionWithSignatureBtn
            // 
            this.addExtensionWithSignatureBtn.Location = new System.Drawing.Point(430, 58);
            this.addExtensionWithSignatureBtn.Name = "addExtensionWithSignatureBtn";
            this.addExtensionWithSignatureBtn.Size = new System.Drawing.Size(75, 23);
            this.addExtensionWithSignatureBtn.TabIndex = 2;
            this.addExtensionWithSignatureBtn.Text = "Add";
            this.addExtensionWithSignatureBtn.UseVisualStyleBackColor = true;
            // 
            // CryptoSteganoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 785);
            this.Controls.Add(this.cryptoanalysisPnl);
            this.Controls.Add(this.hillCipherPnl);
            this.Controls.Add(this.affineCipherPnl);
            this.Controls.Add(this.menuPnl);
            this.Name = "CryptoSteganoForm";
            this.Text = "Form1";
            this.menuPnl.ResumeLayout(false);
            this.hillCipherPnl.ResumeLayout(false);
            this.hillCipherPnl.PerformLayout();
            this.hillKeyGb.ResumeLayout(false);
            this.digramTb.ResumeLayout(false);
            this.digramTb.PerformLayout();
            this.matrixGb.ResumeLayout(false);
            this.matrixGb.PerformLayout();
            this.affineCipherPnl.ResumeLayout(false);
            this.affineCipherPnl.PerformLayout();
            this.affineKeyGb.ResumeLayout(false);
            this.affineKeyGb.PerformLayout();
            this.steganoPnl.ResumeLayout(false);
            this.steganoPnl.PerformLayout();
            this.cryptoanalysisPnl.ResumeLayout(false);
            this.cryptoanalysisPnl.PerformLayout();
            this.addingExtensionWithSignatureGb.ResumeLayout(false);
            this.addingExtensionWithSignatureGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.Button steganographyBtn;
        private System.Windows.Forms.Button cryptoanalyserBtn;
        private System.Windows.Forms.Button hillCipherBtn;
        private System.Windows.Forms.Button affineCipherBtn;
        private System.Windows.Forms.Panel hillCipherPnl;
        private System.Windows.Forms.RadioButton hillDecryptRb;
        private System.Windows.Forms.RadioButton hillEncryptRb;
        private System.Windows.Forms.Button hillBackBtn;
        private System.Windows.Forms.Button hillExitBtn;
        private System.Windows.Forms.Button hillOutputFileBrowseBtn;
        private System.Windows.Forms.Button hillInputFileBrowseBtn;
        private System.Windows.Forms.Label hillOutputFileLbl;
        private System.Windows.Forms.TextBox hillOutputTb;
        private System.Windows.Forms.Label hillInputFileLbl;
        private System.Windows.Forms.TextBox hillInputFileTb;
        private System.Windows.Forms.GroupBox hillKeyGb;
        private System.Windows.Forms.Button hillKeyCorectnessBtn;
        private System.Windows.Forms.GroupBox digramTb;
        private System.Windows.Forms.TextBox hillKeyD1Tb;
        private System.Windows.Forms.TextBox hillKeyD0Tb;
        private System.Windows.Forms.GroupBox matrixGb;
        private System.Windows.Forms.TextBox hillKeyA11Tb;
        private System.Windows.Forms.TextBox hillKeyA01Tb;
        private System.Windows.Forms.TextBox hillKeyA10Tb;
        private System.Windows.Forms.TextBox hillKeyA00Tb;
        private System.Windows.Forms.Button hillExecuteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel affineCipherPnl;
        private System.Windows.Forms.Button affineExecuteBtn;
        private System.Windows.Forms.RadioButton affineDecryptRb;
        private System.Windows.Forms.RadioButton affineEncryptRb;
        private System.Windows.Forms.Button affineBackBtn;
        private System.Windows.Forms.Button affineExitBtn;
        private System.Windows.Forms.Button affineOutputFileBrowseBtn;
        private System.Windows.Forms.Button affineInputFileBrowseBtn;
        private System.Windows.Forms.Label affineOutputFileLbl;
        private System.Windows.Forms.TextBox affineOutputFileTb;
        private System.Windows.Forms.Label affineInputFileLbl;
        private System.Windows.Forms.TextBox affineInputFileTb;
        private System.Windows.Forms.GroupBox affineKeyGb;
        private System.Windows.Forms.Button affineKeyCorrectnessBtn;
        private System.Windows.Forms.TextBox affineKeyBTb;
        private System.Windows.Forms.TextBox affineKeyATb;
        private System.Windows.Forms.Label affineKeyBLbl;
        private System.Windows.Forms.Label affineKeyALbl;
        private System.Windows.Forms.Panel steganoPnl;
        private System.Windows.Forms.Button steganoExecuteBtn;
        private System.Windows.Forms.RadioButton discoverMsgRb;
        private System.Windows.Forms.RadioButton hideMsgRb;
        private System.Windows.Forms.Button steganoBackBtn;
        private System.Windows.Forms.Button steganoExitBtn;
        private System.Windows.Forms.Button msgFileBrowseBtn;
        private System.Windows.Forms.Button inputCoverFileBrowseBtn;
        private System.Windows.Forms.Label msgFileLbl;
        private System.Windows.Forms.TextBox msgFileTb;
        private System.Windows.Forms.Label inputCoverFileLbl;
        private System.Windows.Forms.TextBox inputCoverFileTb;
        private System.Windows.Forms.Button outputCoverFileBrowseBtn;
        private System.Windows.Forms.Label outputCoverFileLbl;
        private System.Windows.Forms.TextBox outputCoverFileTb;
        private System.Windows.Forms.Panel cryptoanalysisPnl;
        private System.Windows.Forms.GroupBox addingExtensionWithSignatureGb;
        private System.Windows.Forms.Button checkEncryptKeyBtn;
        private System.Windows.Forms.Label originalExtensionLbl;
        private System.Windows.Forms.ComboBox extensionsCb;
        private System.Windows.Forms.Button cryptoanalysisExecuteBtn;
        private System.Windows.Forms.Button cryptoanalysisBackBtn;
        private System.Windows.Forms.Button cryptoanalysisExitBtn;
        private System.Windows.Forms.Button decryptedOutputFileBtn;
        private System.Windows.Forms.Button encryptedFileBrowseBtn;
        private System.Windows.Forms.Label decryptedOutputFileLbl;
        private System.Windows.Forms.TextBox decryptedOutputFileTb;
        private System.Windows.Forms.Label encryptedFileLbl;
        private System.Windows.Forms.TextBox encryptedFileTb;
        private System.Windows.Forms.TextBox signatureBytesTb;
        private System.Windows.Forms.TextBox newExtensionTb;
        private System.Windows.Forms.Label signatureBytesLbl;
        private System.Windows.Forms.Label newExtensionLbl;
        private System.Windows.Forms.Button addExtensionWithSignatureBtn;
    }
}

