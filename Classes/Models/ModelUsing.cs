using DatabaseRequests;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsMyBox.Classes.Models
{
    internal sealed class ModelUsing : Model
    {
        //private string dateformat = "dd.";
        private int id { get; set; }
        public ModelBoxes box { get; set; }
        public string customer { get; set; }
        public DateTime timeStarted { get; private set;}
        public DateTime timeFinished { get; private set;}
        public bool blockReassign { get; set; }
        public bool partialUsing { get; set; }

        public ModelUsing()
        {
            tableName = "Using";
        }
        public void AddBoxIntoUsing(int minutes = 60)   // ДОБАВИТЬ обращение к Boxes, изменение статуса на "изъят"
        {
            timeStarted = DateTime.Now;
            timeFinished = DateTime.Now.AddMinutes(minutes);
            using (var conn = GetConnection(DatabasePermissions.All))
            {
                Insert(
                "box, customer, timeStarted, timeFinished, blockReassign, partialUsing",
                $"'{box.number}', '{customer}', '{timeStarted}', '{timeFinished}', 0, 0"
                );
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                Console.WriteLine(GetRequest(false));
                cmd.CommandText = GetRequest();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
