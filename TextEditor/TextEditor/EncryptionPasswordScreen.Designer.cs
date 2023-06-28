namespace TextEditor
{
    partial class EncryptionPasswordScreen
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
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.DecryptButton = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.HeaderLabel.Location = new System.Drawing.Point(220, 51);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(333, 39);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Encryption password";
            this.HeaderLabel.Click += new System.EventHandler(this.HeaderLabel_Click);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.InfoLabel.Location = new System.Drawing.Point(190, 100);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(399, 20);
            this.InfoLabel.TabIndex = 1;
            this.InfoLabel.Text = "The document is encrypted, please enter the password.";
            // 
            // PasswordInput
            // 
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordInput.Location = new System.Drawing.Point(369, 175);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(205, 26);
            this.PasswordInput.TabIndex = 9;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(207, 183);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(108, 13);
            this.InputLabel.TabIndex = 10;
            this.InputLabel.Text = "Encryption password:";
            // 
            // DecryptButton
            // 
            this.DecryptButton.Location = new System.Drawing.Point(325, 325);
            this.DecryptButton.Name = "DecryptButton";
            this.DecryptButton.Size = new System.Drawing.Size(129, 39);
            this.DecryptButton.TabIndex = 18;
            this.DecryptButton.Text = "Decrypt";
            this.DecryptButton.UseVisualStyleBackColor = true;
            this.DecryptButton.Click += new System.EventHandler(this.DecryptButton_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // EncryptionPasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.DecryptButton);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.HeaderLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EncryptionPasswordScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encryption password";
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Button DecryptButton;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}