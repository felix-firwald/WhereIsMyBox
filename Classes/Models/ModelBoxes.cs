using DatabaseRequests;
using System;
using System.Data.SqlClient;

namespace WhereIsMyBox.Classes.Models
{
    internal class ModelBoxes : Model
    {
        public int id { get; private set; }
        public string number { get; set; }
        public string initialLocation { get; set; }
        public string currentLocation { get; set; }
        public string status { get; set; }

        public string category { get; set; }
        public ModelBoxes() : base()
        {
            tableName = "Boxes";
        }
        public string[] GetSplitedNumber()
        {
            string prefix = "";
            string postfix = "";
            foreach (var item in number) 
            { 
                if (char.IsDigit(item))
                {
                    postfix += item;
                }
                else
                {
                    prefix += item;
                }
            }
            return new string[] { prefix, postfix };
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
                    id = Convert.ToInt16(sqlreader["number"]);
                    Console.WriteLine(sqlreader["number"].ToString());
                }
            }
        }
        public void AddBox(string onStatus="Created")
        {
            if ((number??initialLocation??currentLocation) == null)
            {
                throw new Exception(
                    $"One or more of arguments for \"AddBox\" is null!\n" +
                    $"number={number}, initialLocation={initialLocation}, " +
                    $"currentLocation={currentLocation}."
                );
            }
            this.status = onStatus;
        }
        public bool GetBoxByNumber(string num)
        {
            Select("*").WhereEqual("number", new RValue(num.ToString(), Types.STR));
            using (var conn = GetConnection(DatabasePermissions.All))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = GetRequest();
                SqlDataReader sqlreader = cmd.ExecuteReader();
                if (sqlreader.Read())
                {
                    id = Convert.ToInt16(sqlreader["id"].ToString());
                    number = sqlreader["number"].ToString();
                    initialLocation = sqlreader["initialLocation"].ToString();
                    currentLocation = sqlreader["currentLocation"].ToString();
                    status = sqlreader["status"].ToString();
                }
            }
            return true;
        }
    }
}
