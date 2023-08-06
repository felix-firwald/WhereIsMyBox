using System;
using System.Drawing;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using WhereIsMyBox.Classes.Models;
using MySql.Data.MySqlClient;
using System.Windows.Shapes;
using System.Xml;
using System.Runtime.CompilerServices;

namespace Common
{
    public struct ColorTheme
    {
        public static Color MainBackground = Color.FromArgb(82, 81, 87);
        public static Color PanelBackground = Color.FromArgb(58, 57, 61);
        public static Color SubPanelBackground = Color.FromArgb(112, 110, 117);
        public static Color TextBox = Color.FromArgb(222, 226, 230);
        public static Color TextLabel = Color.FromArgb(33, 37, 41);
        public static Color TextHovered = Color.FromArgb(66, 170, 255);
        public static Color Button = Color.FromArgb(252, 163, 17);
        public static Color ButtonBorder = Color.FromArgb(100, 252, 163, 17);
        public static Color ButtonHovered = Color.FromArgb(255, 189, 82);
        public static Color ButtonPressed = Color.FromArgb(255, 216, 153);
    }
}


namespace WhereIsMyBox
{
    public static class CommonData
    {
        public static string login { get; set; }
        public static string place { get; set; }

    }

    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static string getAppDataPath()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return $"{path}\\{Application.ProductName}";
        }
        [STAThread]
        static void Main()
        {
            try
            {
                string appdataPath = getAppDataPath();
                string initFile = $"{appdataPath}\\init.wimb";
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Console.WriteLine(initFile);
                Console.WriteLine(Application.ProductName);
                if (File.Exists(initFile))
                {
                    Application.Run(new AuthForm(TypeOfAuth.SignIn));
                }
                else
                {
                    Directory.CreateDirectory(appdataPath);
                    File.Create(initFile);
                    File.SetAttributes(initFile, FileAttributes.Hidden);
                    Application.Run(new AuthForm(TypeOfAuth.SignUp));
                }
                Application.Run(new Main());
            }
            catch (Exception e)
            {
                MessageBox.Show($"Возникла критическая ошибка:\n\n{e}\n\nПрограмма будет закрыта.", "Ошибка");
            }
        }
    }
}
