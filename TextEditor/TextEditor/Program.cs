using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    internal static class Program
    {
        private static string _encryptionpassword;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }

        public static void CreateFileAndOpen(string path, string name, bool isEncrypted) 
        {
            if (!isEncrypted) 
            {
                FileStream fs = File.Create(path + name + ".document");
                fs.Close();
            }
            else if (isEncrypted)
            {
                FileStream fs = File.Create(path + name + ".encrypteddocument");
                fs.Close();
            }
        }

        public static void OpenFile(string path, bool isEncrypted) 
        {
            //if encrypted go to password screen
            //if not encrypted read text
        }

        public static void SetEncryptionPassword(string encryptionpassword) 
        { 
            _encryptionpassword = encryptionpassword;
        }
    }
}
