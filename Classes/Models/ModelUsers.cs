
using DatabaseRequests;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows;
using static System.Security.Cryptography.SHA256;

namespace WhereIsMyBox.Classes.Models
{
    internal class ModelUsers : Model
    {
        public int id { get; private set; }
        public string login { get; set; }
        public string password {
            private get { return password; }
            set { password = HashPassword(value); } 
        }
        public ModelUsers() : base()
        {
            tableName = "Users";
            
        }
        private string HashPassword(string pwd)
        {
            SHA256 hash = SHA256.Create();
            return Convert.ToString(hash.ComputeHash(Encoding.ASCII.GetBytes(pwd)));
        }
        //public void GetAllUsers()
        //{
        //    using (var conn = GetConnection())
        //    {
        //        Select("*");
        //        conn.Open();
        //        SqlCommand cmd = conn.CreateCommand();
        //        cmd.CommandText = GetRequest();
        //        SqlDataReader sqlreader = cmd.ExecuteReader();
        //        while (sqlreader.Read())
        //        {
        //            Console.WriteLine(sqlreader.ToString());
        //        }
        //    }
        //}
        //public bool IsRightPassword() 
        //{
        //    using (var conn = GetConnection())
        //    {
        //        Select("password").WhereEqual("login", login).WhereEqual("password", password);
        //        conn.Open();
        //        SqlCommand cmd = conn.CreateCommand();
        //        cmd.CommandText = GetRequest();
        //        SqlDataReader sqlreader = cmd.ExecuteReader();
        //        if (sqlreader.Read()) 
        //        { 
        //            return true; 
        //        }
        //        return false;
        //    }
        //}
        public void GetUserById()
        {
        }
    }
}
