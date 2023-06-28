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
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        public void UpdateTextBox(List<string> lines) 
        {
            for (int i = 0; i < lines.Count; i++) 
            {
                TextBox.AppendText($"{lines[i]}\n");
            }
        }
    }
}
