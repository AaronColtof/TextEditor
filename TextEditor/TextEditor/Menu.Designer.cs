namespace TextEditor
{
    partial class Menu
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
            this.DocumentNameTextBox = new System.Windows.Forms.TextBox();
            this.ExstentionLabel = new System.Windows.Forms.Label();
            this.DocumentNameHeader = new System.Windows.Forms.Label();
            this.IsEncryptedLabel = new System.Windows.Forms.Label();
            this.EncryptionPasswordHeader = new System.Windows.Forms.Label();
            this.EncryptionPasswordInput = new System.Windows.Forms.TextBox();
            this.IsEncryptedCheckBox = new System.Windows.Forms.CheckBox();
            this.DisclaimerLabel = new System.Windows.Forms.Label();
            this.CreateDocumentButton = new System.Windows.Forms.Button();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.OpenADocLabel = new System.Windows.Forms.Label();
            this.OpenDocument = new System.Windows.Forms.OpenFileDialog();
            this.OpenDocumentButton = new System.Windows.Forms.Button();
            this.FileLocation = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OpenPath = new System.Windows.Forms.Button();
            this.CreationPathLabel = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // DocumentNameTextBox
            // 
            this.DocumentNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DocumentNameTextBox.Location = new System.Drawing.Point(277, 109);
            this.DocumentNameTextBox.Name = "DocumentNameTextBox";
            this.DocumentNameTextBox.Size = new System.Drawing.Size(205, 26);
            this.DocumentNameTextBox.TabIndex = 8;
            this.DocumentNameTextBox.TextChanged += new System.EventHandler(this.DocumentNameTextBox_TextChanged);
            // 
            // ExstentionLabel
            // 
            this.ExstentionLabel.AutoSize = true;
            this.ExstentionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExstentionLabel.Location = new System.Drawing.Point(481, 118);
            this.ExstentionLabel.Name = "ExstentionLabel";
            this.ExstentionLabel.Size = new System.Drawing.Size(74, 17);
            this.ExstentionLabel.TabIndex = 9;
            this.ExstentionLabel.Text = ".document";
            this.ExstentionLabel.Click += new System.EventHandler(this.ExstentionLabel_Click);
            // 
            // DocumentNameHeader
            // 
            this.DocumentNameHeader.AutoSize = true;
            this.DocumentNameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DocumentNameHeader.Location = new System.Drawing.Point(47, 111);
            this.DocumentNameHeader.Name = "DocumentNameHeader";
            this.DocumentNameHeader.Size = new System.Drawing.Size(161, 25);
            this.DocumentNameHeader.TabIndex = 10;
            this.DocumentNameHeader.Text = "Document name:";
            this.DocumentNameHeader.Click += new System.EventHandler(this.DocumentNameHeader_Click);
            // 
            // IsEncryptedLabel
            // 
            this.IsEncryptedLabel.AutoSize = true;
            this.IsEncryptedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.IsEncryptedLabel.Location = new System.Drawing.Point(47, 243);
            this.IsEncryptedLabel.Name = "IsEncryptedLabel";
            this.IsEncryptedLabel.Size = new System.Drawing.Size(124, 25);
            this.IsEncryptedLabel.TabIndex = 11;
            this.IsEncryptedLabel.Text = "Is encrypted:";
            this.IsEncryptedLabel.Click += new System.EventHandler(this.IsEncryptedLabel_Click);
            // 
            // EncryptionPasswordHeader
            // 
            this.EncryptionPasswordHeader.AutoSize = true;
            this.EncryptionPasswordHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EncryptionPasswordHeader.Location = new System.Drawing.Point(47, 309);
            this.EncryptionPasswordHeader.Name = "EncryptionPasswordHeader";
            this.EncryptionPasswordHeader.Size = new System.Drawing.Size(199, 25);
            this.EncryptionPasswordHeader.TabIndex = 13;
            this.EncryptionPasswordHeader.Text = "Encryption password:";
            this.EncryptionPasswordHeader.Click += new System.EventHandler(this.EncryptionPasswordHeader_Click);
            // 
            // EncryptionPasswordInput
            // 
            this.EncryptionPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EncryptionPasswordInput.Location = new System.Drawing.Point(277, 310);
            this.EncryptionPasswordInput.Name = "EncryptionPasswordInput";
            this.EncryptionPasswordInput.PasswordChar = '*';
            this.EncryptionPasswordInput.Size = new System.Drawing.Size(205, 26);
            this.EncryptionPasswordInput.TabIndex = 14;
            this.EncryptionPasswordInput.TextChanged += new System.EventHandler(this.EncryptionPasswordInput_TextChanged);
            // 
            // IsEncryptedCheckBox
            // 
            this.IsEncryptedCheckBox.AutoSize = true;
            this.IsEncryptedCheckBox.Location = new System.Drawing.Point(277, 252);
            this.IsEncryptedCheckBox.Name = "IsEncryptedCheckBox";
            this.IsEncryptedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.IsEncryptedCheckBox.TabIndex = 15;
            this.IsEncryptedCheckBox.UseVisualStyleBackColor = true;
            this.IsEncryptedCheckBox.CheckedChanged += new System.EventHandler(this.IsEncryptedCheckBox_CheckedChanged);
            // 
            // DisclaimerLabel
            // 
            this.DisclaimerLabel.AutoSize = true;
            this.DisclaimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DisclaimerLabel.Location = new System.Drawing.Point(120, 365);
            this.DisclaimerLabel.MaximumSize = new System.Drawing.Size(400, 0);
            this.DisclaimerLabel.Name = "DisclaimerLabel";
            this.DisclaimerLabel.Size = new System.Drawing.Size(350, 34);
            this.DisclaimerLabel.TabIndex = 16;
            this.DisclaimerLabel.Text = "Disclaimer: encryption is still in beta, please dont store sensitive data in encr" +
    "ypted documents";
            this.DisclaimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DisclaimerLabel.Click += new System.EventHandler(this.DisclaimerLabel_Click);
            // 
            // CreateDocumentButton
            // 
            this.CreateDocumentButton.Location = new System.Drawing.Point(219, 419);
            this.CreateDocumentButton.Name = "CreateDocumentButton";
            this.CreateDocumentButton.Size = new System.Drawing.Size(129, 39);
            this.CreateDocumentButton.TabIndex = 17;
            this.CreateDocumentButton.Text = "Create document";
            this.CreateDocumentButton.UseVisualStyleBackColor = true;
            this.CreateDocumentButton.Click += new System.EventHandler(this.CreateDocumentButton_Click);
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.CreateLabel.Location = new System.Drawing.Point(123, 34);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(305, 39);
            this.CreateLabel.TabIndex = 18;
            this.CreateLabel.Text = "Create a document";
            // 
            // OpenADocLabel
            // 
            this.OpenADocLabel.AutoSize = true;
            this.OpenADocLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.OpenADocLabel.Location = new System.Drawing.Point(656, 34);
            this.OpenADocLabel.Name = "OpenADocLabel";
            this.OpenADocLabel.Size = new System.Drawing.Size(286, 39);
            this.OpenADocLabel.TabIndex = 19;
            this.OpenADocLabel.Text = "Open a document";
            // 
            // OpenDocument
            // 
            this.OpenDocument.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenDocument_FileOk);
            // 
            // OpenDocumentButton
            // 
            this.OpenDocumentButton.Location = new System.Drawing.Point(739, 104);
            this.OpenDocumentButton.Name = "OpenDocumentButton";
            this.OpenDocumentButton.Size = new System.Drawing.Size(129, 39);
            this.OpenDocumentButton.TabIndex = 20;
            this.OpenDocumentButton.Text = "Open document";
            this.OpenDocumentButton.UseVisualStyleBackColor = true;
            this.OpenDocumentButton.Click += new System.EventHandler(this.OpenDocumentButton_Click);
            // 
            // FileLocation
            // 
            this.FileLocation.AutoSize = true;
            this.FileLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FileLocation.Location = new System.Drawing.Point(47, 180);
            this.FileLocation.Name = "FileLocation";
            this.FileLocation.Size = new System.Drawing.Size(121, 25);
            this.FileLocation.TabIndex = 21;
            this.FileLocation.Text = "File location:";
            this.FileLocation.Click += new System.EventHandler(this.FileLocation_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog_HelpRequest);
            // 
            // OpenPath
            // 
            this.OpenPath.Location = new System.Drawing.Point(277, 176);
            this.OpenPath.Name = "OpenPath";
            this.OpenPath.Size = new System.Drawing.Size(88, 29);
            this.OpenPath.TabIndex = 22;
            this.OpenPath.Text = "Select location";
            this.OpenPath.UseVisualStyleBackColor = true;
            this.OpenPath.Click += new System.EventHandler(this.OpenPath_Click);
            // 
            // CreationPathLabel
            // 
            this.CreationPathLabel.AutoSize = true;
            this.CreationPathLabel.Location = new System.Drawing.Point(371, 184);
            this.CreationPathLabel.Name = "CreationPathLabel";
            this.CreationPathLabel.Size = new System.Drawing.Size(28, 13);
            this.CreationPathLabel.TabIndex = 23;
            this.CreationPathLabel.Text = "path";
            this.CreationPathLabel.Click += new System.EventHandler(this.CreationPathLabel_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.CreationPathLabel);
            this.Controls.Add(this.OpenPath);
            this.Controls.Add(this.FileLocation);
            this.Controls.Add(this.OpenDocumentButton);
            this.Controls.Add(this.OpenADocLabel);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.CreateDocumentButton);
            this.Controls.Add(this.DisclaimerLabel);
            this.Controls.Add(this.IsEncryptedCheckBox);
            this.Controls.Add(this.EncryptionPasswordInput);
            this.Controls.Add(this.EncryptionPasswordHeader);
            this.Controls.Add(this.IsEncryptedLabel);
            this.Controls.Add(this.DocumentNameHeader);
            this.Controls.Add(this.ExstentionLabel);
            this.Controls.Add(this.DocumentNameTextBox);
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextEditor";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DocumentNameTextBox;
        private System.Windows.Forms.Label ExstentionLabel;
        private System.Windows.Forms.Label DocumentNameHeader;
        private System.Windows.Forms.Label IsEncryptedLabel;
        private System.Windows.Forms.Label EncryptionPasswordHeader;
        private System.Windows.Forms.TextBox EncryptionPasswordInput;
        private System.Windows.Forms.CheckBox IsEncryptedCheckBox;
        private System.Windows.Forms.Label DisclaimerLabel;
        private System.Windows.Forms.Button CreateDocumentButton;
        private System.Windows.Forms.Label CreateLabel;
        private System.Windows.Forms.Label OpenADocLabel;
        private System.Windows.Forms.OpenFileDialog OpenDocument;
        private System.Windows.Forms.Button OpenDocumentButton;
        private System.Windows.Forms.Label FileLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button OpenPath;
        private System.Windows.Forms.Label CreationPathLabel;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}

