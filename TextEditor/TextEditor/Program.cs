using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace TextEditor
{
    internal static class Program
    {
        private static string _encryptionpassword;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        public static void CreateFileAndOpen(string path, string name, bool isEncrypted, Menu origin) 
        {
            if (!isEncrypted) 
            {
                FileStream fs = File.Create(path + name + ".document");
                fs.Close();
                OpenFile(path + name + ".document", false, origin);
            }
            else if (isEncrypted)
            {
                FileStream fs = File.Create(path + name + ".encrypteddocument");

                string datastring = $"<encryptionkey={_encryptionpassword}>"; 
                byte[] info = new UTF8Encoding(true).GetBytes(datastring);
                fs.Write(info, 0, info.Length);

                fs.Close();
                OpenFile(path + name + ".encrypteddocument", true, origin);
            }
        }

        public static void OpenFile(string path, bool isEncrypted, Menu origin) 
        {

            if (isEncrypted) 
            {
                EncryptionPasswordScreen encryptionPasswordScreen = new EncryptionPasswordScreen();
                encryptionPasswordScreen.Show();
                encryptionPasswordScreen.selectedFile = path;
            }

            if (!isEncrypted) 
            {
                List<string> lines = new List<string>();

                try
                {
                    var enumLines = File.ReadLines(path);

                    foreach (var line in enumLines)
                    {
                        lines.Add(line);
                    }
                }

                catch (FileNotFoundException)
                {
                    origin.FileNotFound();
                    return;
                }

                TextEditor textEditor = new TextEditor();
                textEditor.UpdateTextBox(lines);
                textEditor.Show();
            }
        }

        public static void TryDecryption(string path, string password, EncryptionPasswordScreen origin)
        {
            List<string> lines = new List<string>();

            string key = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                key += password;
            }

            try 
            {
                var enumLines = File.ReadLines(path);

                foreach (var line in enumLines) 
                { 
                    lines.Add(line);
                }
            }
            
            catch(FileNotFoundException) 
            {
                origin.FileNotAvailable();
                return;
            }

            if (lines[0] == $"<encryptionkey={key}>")
            {
                //open file just like normal (with the text passed through the function)
            }
            else
            {
                origin.WrongPassword();
            }
        }

        public static void SetEncryptionPassword(string encryptionpassword) 
        {
            string key = string.Empty;

            for (int i = 0; i < 10; i++) 
            {
                key += encryptionpassword;
            }

            _encryptionpassword = key;
        }
    }
}
