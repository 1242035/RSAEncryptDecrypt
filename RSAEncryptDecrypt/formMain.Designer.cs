namespace RSAEncryptDecrypt
{
    partial class formMain
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
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.tabCreateKey = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreateKey = new System.Windows.Forms.Button();
            this.encryptGroup = new System.Windows.Forms.GroupBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEncrypt = new System.Windows.Forms.TabPage();
            this.targetEncryptPictureBox = new System.Windows.Forms.PictureBox();
            this.sourceEncryptPictureBox = new System.Windows.Forms.PictureBox();
            this.btnTabEncryptOpenFile = new System.Windows.Forms.Button();
            this.txtTbEncryptKey = new System.Windows.Forms.TextBox();
            this.lblTabEncryptKey = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.tabDecrypt = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecryptKey = new System.Windows.Forms.TextBox();
            this.btnDecryptDest = new System.Windows.Forms.Button();
            this.destPictureBox = new System.Windows.Forms.PictureBox();
            this.descryptPictureBox = new System.Windows.Forms.PictureBox();
            this.tabCreateKey.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.encryptGroup.SuspendLayout();
            this.tabEncrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetEncryptPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceEncryptPictureBox)).BeginInit();
            this.tabDecrypt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descryptPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(330, 203);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Gải Mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // tabCreateKey
            // 
            this.tabCreateKey.Controls.Add(this.tabPage1);
            this.tabCreateKey.Controls.Add(this.tabEncrypt);
            this.tabCreateKey.Controls.Add(this.tabDecrypt);
            this.tabCreateKey.Location = new System.Drawing.Point(12, 1);
            this.tabCreateKey.Name = "tabCreateKey";
            this.tabCreateKey.SelectedIndex = 0;
            this.tabCreateKey.Size = new System.Drawing.Size(817, 257);
            this.tabCreateKey.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCreateKey);
            this.tabPage1.Controls.Add(this.encryptGroup);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tạo Khóa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreateKey
            // 
            this.btnCreateKey.Location = new System.Drawing.Point(385, 115);
            this.btnCreateKey.Name = "btnCreateKey";
            this.btnCreateKey.Size = new System.Drawing.Size(75, 23);
            this.btnCreateKey.TabIndex = 6;
            this.btnCreateKey.Text = "Tạo Khóa";
            this.btnCreateKey.UseVisualStyleBackColor = true;
            this.btnCreateKey.Click += new System.EventHandler(this.btnCreateKey_Click);
            // 
            // encryptGroup
            // 
            this.encryptGroup.Controls.Add(this.txtKey);
            this.encryptGroup.Controls.Add(this.label1);
            this.encryptGroup.Location = new System.Drawing.Point(47, 6);
            this.encryptGroup.Name = "encryptGroup";
            this.encryptGroup.Size = new System.Drawing.Size(696, 103);
            this.encryptGroup.TabIndex = 5;
            this.encryptGroup.TabStop = false;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(275, 20);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(254, 20);
            this.txtKey.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Khóa";
            // 
            // tabEncrypt
            // 
            this.tabEncrypt.Controls.Add(this.targetEncryptPictureBox);
            this.tabEncrypt.Controls.Add(this.sourceEncryptPictureBox);
            this.tabEncrypt.Controls.Add(this.btnTabEncryptOpenFile);
            this.tabEncrypt.Controls.Add(this.txtTbEncryptKey);
            this.tabEncrypt.Controls.Add(this.lblTabEncryptKey);
            this.tabEncrypt.Controls.Add(this.btnEncrypt);
            this.tabEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tabEncrypt.Name = "tabEncrypt";
            this.tabEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncrypt.Size = new System.Drawing.Size(809, 231);
            this.tabEncrypt.TabIndex = 1;
            this.tabEncrypt.Text = "Mã Hóa";
            this.tabEncrypt.UseVisualStyleBackColor = true;
            // 
            // targetEncryptPictureBox
            // 
            this.targetEncryptPictureBox.Location = new System.Drawing.Point(405, 55);
            this.targetEncryptPictureBox.Name = "targetEncryptPictureBox";
            this.targetEncryptPictureBox.Size = new System.Drawing.Size(290, 120);
            this.targetEncryptPictureBox.TabIndex = 6;
            this.targetEncryptPictureBox.TabStop = false;
            // 
            // sourceEncryptPictureBox
            // 
            this.sourceEncryptPictureBox.Location = new System.Drawing.Point(92, 53);
            this.sourceEncryptPictureBox.Name = "sourceEncryptPictureBox";
            this.sourceEncryptPictureBox.Size = new System.Drawing.Size(296, 122);
            this.sourceEncryptPictureBox.TabIndex = 5;
            this.sourceEncryptPictureBox.TabStop = false;
            // 
            // btnTabEncryptOpenFile
            // 
            this.btnTabEncryptOpenFile.Location = new System.Drawing.Point(595, 26);
            this.btnTabEncryptOpenFile.Name = "btnTabEncryptOpenFile";
            this.btnTabEncryptOpenFile.Size = new System.Drawing.Size(100, 23);
            this.btnTabEncryptOpenFile.TabIndex = 4;
            this.btnTabEncryptOpenFile.Text = "Chọn hình ảnh";
            this.btnTabEncryptOpenFile.UseVisualStyleBackColor = true;
            this.btnTabEncryptOpenFile.Click += new System.EventHandler(this.btnTabEncryptOpenFile_Click);
            // 
            // txtTbEncryptKey
            // 
            this.txtTbEncryptKey.Location = new System.Drawing.Point(239, 27);
            this.txtTbEncryptKey.Name = "txtTbEncryptKey";
            this.txtTbEncryptKey.Size = new System.Drawing.Size(315, 20);
            this.txtTbEncryptKey.TabIndex = 3;
            // 
            // lblTabEncryptKey
            // 
            this.lblTabEncryptKey.AutoSize = true;
            this.lblTabEncryptKey.Location = new System.Drawing.Point(194, 31);
            this.lblTabEncryptKey.Name = "lblTabEncryptKey";
            this.lblTabEncryptKey.Size = new System.Drawing.Size(32, 13);
            this.lblTabEncryptKey.TabIndex = 2;
            this.lblTabEncryptKey.Text = "Khóa";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(362, 181);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "Mã Hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // tabDecrypt
            // 
            this.tabDecrypt.Controls.Add(this.descryptPictureBox);
            this.tabDecrypt.Controls.Add(this.destPictureBox);
            this.tabDecrypt.Controls.Add(this.btnDecryptDest);
            this.tabDecrypt.Controls.Add(this.txtDecryptKey);
            this.tabDecrypt.Controls.Add(this.label2);
            this.tabDecrypt.Controls.Add(this.btnDecrypt);
            this.tabDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tabDecrypt.Name = "tabDecrypt";
            this.tabDecrypt.Size = new System.Drawing.Size(809, 231);
            this.tabDecrypt.TabIndex = 2;
            this.tabDecrypt.Text = "Giải Mã";
            this.tabDecrypt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Khóa";
            // 
            // txtDecryptKey
            // 
            this.txtDecryptKey.Location = new System.Drawing.Point(254, 41);
            this.txtDecryptKey.Name = "txtDecryptKey";
            this.txtDecryptKey.Size = new System.Drawing.Size(180, 20);
            this.txtDecryptKey.TabIndex = 3;
            // 
            // btnDecryptDest
            // 
            this.btnDecryptDest.Location = new System.Drawing.Point(529, 37);
            this.btnDecryptDest.Name = "btnDecryptDest";
            this.btnDecryptDest.Size = new System.Drawing.Size(75, 23);
            this.btnDecryptDest.TabIndex = 4;
            this.btnDecryptDest.Text = "Chọn hình ảnh mã hóa";
            this.btnDecryptDest.UseVisualStyleBackColor = true;
            this.btnDecryptDest.Click += new System.EventHandler(this.btnDecryptDest_Click);
            // 
            // destPictureBox
            // 
            this.destPictureBox.Location = new System.Drawing.Point(159, 96);
            this.destPictureBox.Name = "destPictureBox";
            this.destPictureBox.Size = new System.Drawing.Size(173, 83);
            this.destPictureBox.TabIndex = 5;
            this.destPictureBox.TabStop = false;
            // 
            // descryptPictureBox
            // 
            this.descryptPictureBox.Location = new System.Drawing.Point(416, 96);
            this.descryptPictureBox.Name = "descryptPictureBox";
            this.descryptPictureBox.Size = new System.Drawing.Size(188, 83);
            this.descryptPictureBox.TabIndex = 6;
            this.descryptPictureBox.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 261);
            this.Controls.Add(this.tabCreateKey);
            this.Name = "formMain";
            this.Text = "Mã hóa và giải mã hình anh";
            this.tabCreateKey.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.encryptGroup.ResumeLayout(false);
            this.encryptGroup.PerformLayout();
            this.tabEncrypt.ResumeLayout(false);
            this.tabEncrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetEncryptPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceEncryptPictureBox)).EndInit();
            this.tabDecrypt.ResumeLayout(false);
            this.tabDecrypt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.destPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descryptPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TabControl tabCreateKey;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabEncrypt;
        private System.Windows.Forms.Button btnCreateKey;
        private System.Windows.Forms.GroupBox encryptGroup;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TabPage tabDecrypt;
        private System.Windows.Forms.TextBox txtTbEncryptKey;
        private System.Windows.Forms.Label lblTabEncryptKey;
        private System.Windows.Forms.Button btnTabEncryptOpenFile;
        private System.Windows.Forms.PictureBox sourceEncryptPictureBox;
        private System.Windows.Forms.PictureBox targetEncryptPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecryptKey;
        private System.Windows.Forms.Button btnDecryptDest;
        private System.Windows.Forms.PictureBox descryptPictureBox;
        private System.Windows.Forms.PictureBox destPictureBox;
    }
}

