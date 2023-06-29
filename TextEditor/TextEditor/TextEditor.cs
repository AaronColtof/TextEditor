using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class TextEditor : Form
    {
        string path;
        string encryptionPassword;
        bool isEncrypted;

        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateTextBox(List<string> lines, string _path, bool _isEncrypted, string _encryptionPassword) 
        {
            for (int i = 0; i < lines.Count; i++) 
            {
                TextBox.Text += ($"{lines[i]} {Environment.NewLine}");
            }

            path = _path;
            isEncrypted = _isEncrypted;
            SetKey(_encryptionPassword);
        }

        private void SaveDocument_Click(object sender, EventArgs e)
        {
            List<string> lines = new List<string>();

            if (isEncrypted)
            {
                lines.Add($"<encryptionkey={encryptionPassword}>");
            }

            for (int i = 0; i < TextBox.Lines.Count(); i++)
                lines.Add(TextBox.Lines[i].Replace(Environment.NewLine, "").Trim());

            if (isEncrypted) 
            {
                //encrypt every single line in the list
            }

            Program.SaveFile(lines, path, isEncrypted, this);
        }

        private void SetKey(string _encryptionPassword)
        {
            string key = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                key += _encryptionPassword;
            }

            encryptionPassword = key;
        }
    }
}
