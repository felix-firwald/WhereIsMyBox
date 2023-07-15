using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Appearance
{
    public struct ColorTheme
    {
        public static Color MainBackground = Color.FromArgb(82, 81, 87);
        public static Color PanelBackground = Color.FromArgb(58, 57, 61);
        public static Color SubPanelBackground = Color.FromArgb(112, 110, 117);
        public static Color TextBox = Color.FromArgb(222, 226, 230);
        public static Color TextLabel = Color.FromArgb(33, 37, 41);
        public static Color Button = Color.FromArgb(252, 163, 17);

        public Color GetMain()
        {
            return MainBackground;
        }

        public Color GetPanel()
        {
            return PanelBackground;
        }

        public Color GetSubPanel()
        {
            return SubPanelBackground;
        }

        public Color GetTextBox()
        {
            return TextBox;
        }

        public Color GetTextLabel()
        {
            return TextLabel;
        }

        public Color GetButton()
        {
            return Button;
        }
    }
}


namespace WhereIsMyBox
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>

        [STAThread]
        static void Main()
        {
            try
            {
                string appdataPath = $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}\\{Application.ProductName}";
                string initFile = $"{appdataPath}\\init.wimb";
                string configFile = $"{appdataPath}\\config.wimb";
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Console.WriteLine(initFile);
                Console.WriteLine(Application.ProductName);
                if (File.Exists(initFile))
                {
                    Application.Run(new AuthForm(false));
                }
                else
                {
                    File.Create(initFile);
                    File.SetAttributes(initFile, FileAttributes.Hidden);
                    Loading loadd = new Loading("Инициализация программы");
                    loadd.Show();
                    Directory.CreateDirectory(appdataPath);
                    string text = $"[LOGIN]={{{Environment.UserName}}}\r\n" +
                        $"[PASSWORD]={{{Environment.MachineName}}}\r\n";
                    File.Create(configFile).Close();
                    StreamWriter sw = File.AppendText(configFile);
                    sw.WriteLine(text);
                    sw.Close();
                    //File.Encrypt(configFile);
                    File.SetAttributes(configFile, FileAttributes.Hidden);
                    loadd.Close();
                    Application.Run(new AuthForm(true));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Возникла критическая ошибка при работе программы:\n\n{e}", "Ошибка");
            }
        }
    }
}
