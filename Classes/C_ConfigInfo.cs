using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsMyBox.Classes
{
    internal class ConfigInfo
    {
        // main vars
        public string login;
        public string location;
        public string status;
        private string password;
        private string file = $"{Program.getAppDataPath()}\\config.wimb";
        // procedural vars
        private char assign = '=';
        private char sep = '|';
        public ConfigInfo(string login="", string location="", string password="", string status="")
        {
            this.login = login;
            this.location = location;
            this.password = HashPassword(password);
            this.status = status;
        }
        private string HashPassword(string pwd)
        {
            SHA256 hash = SHA256.Create();
            string result = Encoding.UTF8.GetString(hash.ComputeHash(Encoding.UTF8.GetBytes(pwd)));
            Console.WriteLine(result);
            return result;
        }
        public ConfigInfo WriteConfig()
        {
            List<string> array = new List<string>
            {
                $"LOGIN{assign}{login}",
                $"LOCATION{assign}{location}",
                $"STATUS{assign}{status}",
                $"PASSWORD{assign}{password}"
            };
            string result = string.Join("|", array);

            File.WriteAllText(file, result);
            File.SetAttributes(file, FileAttributes.Hidden);
            return this;
        }
        public ConfigInfo ReadConfig()
        {
            string text = File.ReadAllText(file);
            foreach (string field in text.Split(sep))
            {
                string[] str = field.Split(assign);
                switch(str[0])
                {
                    case "LOGIN":
                        this.login = str[1];
                        break;
                    case "LOCATION":
                        this.location = str[1];
                        break;
                    case "PASSWORD":
                        this.password = str[1];
                        break;
                    case "STATUS":
                        this.status = str[1];
                        break;
                }
            }
            return this;
        }
        public ConfigInfo DestroyConfig()
        {
            File.Delete(file);
            return this;
        }
        public bool IsPasswordRight(string pwd)
        {
            return password == HashPassword(pwd);
        }
    }
}
