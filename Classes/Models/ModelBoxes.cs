using DatabaseRequests;
using System;
using System.Data.SqlClient;

namespace WhereIsMyBox.Classes.Models
{
    internal class ModelBoxes : Model
    {
        public int Id { get; private set; }
        public string Number { get; set; }
        public string initialLocation { get; set; }
        public string currentLocation { get; set; }
        public string status { get; set; }
        public ModelBoxes() : base()
        {
            tableName = "Boxes";
        }
        public void GetAllObjects()
        {
            using (var conn = GetConnection(DatabasePermissions.AdminOnly))
            {
                Select("*");
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = GetRequest();
                SqlDataReader sqlreader = cmd.ExecuteReader();
                while (sqlreader.Read())
                {
                    Id = Convert.ToInt16(sqlreader["number"]);
                    Console.WriteLine(sqlreader["number"].ToString());
                }
            }
        } 
    }
}
