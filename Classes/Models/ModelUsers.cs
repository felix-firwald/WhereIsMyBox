
using DatabaseRequests;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WhereIsMyBox.Classes.Models
{
    internal class ModelUsers : Model
    {
        public ModelUsers() : base()
        {
            tableName = "Users";
            AddColumn(name:"id", type:"int");
            AddColumn(name: "name", type: "nvarchar(50)");
            
        }
        public void GetAllUsers()
        {
            using (var conn = GetConnection(DatabasePermissions.All))
            {
                Select("*");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = GetRequest();
                SqlDataReader sqlreader = cmd.ExecuteReader();
                while (sqlreader.Read())
                {
                    Console.WriteLine(sqlreader.ToString());
                }
            }
        }
    }
}
