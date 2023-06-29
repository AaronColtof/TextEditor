namespace TextEditor
{
    partial class TextEditor
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
            this.Header = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SaveDocument = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.AutoSize = true;
            this.Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Header.Location = new System.Drawing.Point(820, 23);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(209, 46);
            this.Header.TabIndex = 0;
            this.Header.Text = "Text editor";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(64, 88);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(1772, 624);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // SaveDocument
            // 
            this.SaveDocument.Location = new System.Drawing.Point(856, 727);
            this.SaveDocument.Name = "SaveDocument";
            this.SaveDocument.Size = new System.Drawing.Size(129, 39);
            this.SaveDocument.TabIndex = 18;
            this.SaveDocument.Text = "Save document";
            this.SaveDocument.UseVisualStyleBackColor = true;
            this.SaveDocument.Click += new System.EventHandler(this.SaveDocument_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // TextEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.SaveDocument);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Header);
            this.Name = "TextEditor";
            this.Text = "TextEditor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Header;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button SaveDocument;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}