using DatabaseRequests;
using System;
using System.Data.SqlClient;

namespace WhereIsMyBox.Classes.Models
{
    internal sealed class ModelBoxes : Model
    {
        public int id { get; private set; }
        public string number { get; set; }
        public string initialLocation { get; set; }
        public string currentPlace { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string note { get; set; }
        public string user { get; set; }
        public DateTime willFree { get; set; }
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
            return new string[2] { prefix, postfix };
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
        public void AddBox(string onStatus="Created")   // НЕ ДОПИСАНО!
        {
            if ((number??initialLocation??currentPlace) == null)
            {
                throw new Exception(
                    $"One or more of arguments for \"AddBox\" is null!\n" +
                    $"number={number}, initialLocation={initialLocation}, " +
                    $"currentLocation={currentPlace}."
                );
            }
            
            this.status = onStatus;
            Insert(
                "number, initialLocation, currentPlace, status, type, note",
                $"{this.number}, {this.initialLocation}, {this.currentPlace}, {this.status}, {this.type}, {this.note}"
            );
        }
        public bool GetBoxByNumber(string num)
        {
            Select("*").WhereEqual("number", num);
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
                    currentPlace = sqlreader["currentPlace"].ToString();
                    status = sqlreader["status"].ToString();
                    type = sqlreader["type"].ToString();
                    note = sqlreader["note"].ToString();
                    user = "-";
                    willFree = DateTime.Now;
                    return true;
                }
            }
            return false;
        }
    }
}
