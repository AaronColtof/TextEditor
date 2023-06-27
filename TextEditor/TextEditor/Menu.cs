using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Menu : Form
    {
        private string _filecreationlocation;

        public Menu()
        {
            InitializeComponent();
            DisableEncryptedPassword();
        }

        private void DisableEncryptedPassword() 
        {
            EncryptionPasswordHeader.Enabled = false;
            EncryptionPasswordInput.Enabled = false;
            DisclaimerLabel.Visible = false;
        }

        private void DocumentNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExstentionLabel_Click(object sender, EventArgs e)
        {

        }

        private void DocumentNameHeader_Click(object sender, EventArgs e)
        {

        }

        private void IsEncryptedLabel_Click(object sender, EventArgs e)
        {
            IsEncryptedCheckBox.Checked = !IsEncryptedCheckBox.Checked;
        }

        private void EncryptionPasswordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void EncryptionPasswordHeader_Click(object sender, EventArgs e)
        {

        }

        private void IsEncryptedCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void IsEncryptedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IsEncryptedCheckBox.Checked)
            {
                EncryptionPasswordHeader.Enabled = true;
                EncryptionPasswordInput.Enabled = true;
                ExstentionLabel.Text = ".encrypteddocument";
                DisclaimerLabel.Visible = true;
            }
            else 
            {
                EncryptionPasswordHeader.Enabled = false;
                EncryptionPasswordInput.Enabled = false;
                ExstentionLabel.Text = ".document";
                DisclaimerLabel.Visible = false;
            }
        }

        private void DisclaimerLabel_Click(object sender, EventArgs e)
        {

        }

        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            if (IsEncryptedCheckBox.Checked && EncryptionPasswordInput.Text == string.Empty) { return; }
        }

        private void OpenDocument_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void OpenDocumentButton_Click(object sender, EventArgs e)
        {
            OpenDocument.ShowDialog();
            string filelocation = OpenDocument.FileName;
            if (Path.GetExtension(filelocation) == ".document" || Path.GetExtension(filelocation) == ".encrypteddocument")
            {
                //file approved           
            }
            else 
            {
                ErrorProvider.SetError(OpenDocumentButton, "Wrong extenstion, only .document and .encrypteddocument are readable via this editor!");
            }
        }

        private void FileLocation_Click(object sender, EventArgs e)
        {

        }

        private void CreationPathLabel_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(_filecreationlocation))
            {
                Process.Start("explorer.exe", _filecreationlocation);
            }
        }
        

        private void OpenPath_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.ShowDialog();
            _filecreationlocation = folderBrowserDialog.SelectedPath;
            CreationPathLabel.Text = _filecreationlocation;
        }

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {
            
        }
    }
}
