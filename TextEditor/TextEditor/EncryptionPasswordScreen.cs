using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class EncryptionPasswordScreen : Form
    {
        public string selectedFile;
        public EncryptionPasswordScreen()
        {
            InitializeComponent();
        }

        private void HeaderLabel_Click(object sender, EventArgs e)
        {

        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (PasswordInput.Text != string.Empty)
            {
                Program.TryDecryption(selectedFile, PasswordInput.Text, this);
            }
            else 
            {
                ErrorProvider.SetError(PasswordInput, "Please enter an encryption password");
            }
        }

        public void FileNotAvailable() 
        {
            ErrorProvider.SetError(DecryptButton, "The system hasn't found the selected file, please restart the application");
        }

        public void WrongPassword() 
        {
            ErrorProvider.SetError(PasswordInput, "Incorrect password");
        }

        public void DecryptionSuccessful() 
        {
            this.Close();
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
