using DatabaseRequests;
using System;
using System.Data;
using System.Data.SqlClient;

namespace WhereIsMyBox.Classes.Models
{
    internal sealed class ModelBoxes : Model
    {
        public int id { get; private set; }
        public string number { get; set; }
        public string location { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public string note { get; set; }
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

        #region Create
        public void AddBox(string onStatus="Created")   // НЕ ДОПИСАНО!
        {
            if ((number??location) == null)
            {
                throw new Exception(
                    $"One or more of arguments for \"AddBox\" is null!\n" +
                    $"number={number}, location={location}"
                );
            }
            
            this.status = onStatus;
            Insert(
                "number, location, status, type, note",
                $"{this.number}, {this.location}, {this.status}, {this.type}, {this.note}"
            );
            Execute(DatabasePermissions.All);
        }
        #endregion

        #region Read
        //public ModelBoxes[] GetAllObjects()
        //{
        //    using (var conn = GetConnection(DatabasePermissions.AdminOnly))
        //    {
        //        Select("*");
        //        conn.Open();
        //        SqlCommand cmd = conn.CreateCommand();
        //        cmd.CommandText = GetRequest();
        //        SqlDataReader sqlreader = cmd.ExecuteReader();
        //        while (sqlreader.Read())
        //        {
        //            id = Convert.ToInt16(sqlreader["number"]);
        //            Console.WriteLine(sqlreader["number"].ToString());
        //        }
        //    }
        //}
        public bool GetBoxByNumber(string num)
        {
            Select("*").WhereEqual("number", num);
            DataTable dt = Execute(DatabasePermissions.All);
            try
            {
                DataRow dr = dt.Rows[0];
                //id = Convert.ToInt16(dr["id"].ToString());
                number = dr["number"].ToString();
                location = dr["location"].ToString();
                //currentPlace = dr["currentPlace"].ToString();
                status = dr["status"].ToString();
                type = dr["type"].ToString();
                note = dr["note"].ToString();
                willFree = DateTime.Now;
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        #endregion

        #region Update
        public void UpdateStatus(string onStatus)
        {
            Update("status", onStatus).WhereEqual("number", this.number);
        }
        #endregion
    }
}
