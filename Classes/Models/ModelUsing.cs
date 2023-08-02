using DatabaseRequests;
using System;
using System.Collections.Generic;
using System.Data;
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
        public string box { get; set; }
        public string place { get; set; }
        public string customer { get; set; }
        public DateTime timeStarted { get; set;}
        public DateTime timeFinished { get; private set;}
        public bool inFocus { get; set; }
        public bool finished { get; set; }

        public ModelUsing()
        {
            tableName = "BoxesInUse";
        }
        public void AddBoxIntoUsing(int minutes = 60)   // ДОБАВИТЬ обращение к Boxes, изменение статуса на "изъят"
        {
            timeStarted = DateTime.Now;
            timeFinished = DateTime.Now.AddMinutes(minutes);
            int focus = Convert.ToInt32(inFocus);
            Insert(
                "box, place, customer, timeStarted, timeFinished, inFocus, finished",
                $"'{box}', '{place}', '{customer}', '{timeStarted}', '{timeFinished}', {focus}, 0"
            );
            DataTable dt = Execute(DatabasePermissions.All);
        }
        public async void ReturnSeizing()
        {
            await Task.Run(() =>
            {
                Update("finished", "1", false);
                Update("timeFinished", DateTime.Now.ToString());
                WhereEqual("box", box);
                WhereEqual("timeStarted", timeStarted.ToString());
                Execute(DatabasePermissions.All);
            });
        }
        public async void UpdateFocus()
        {
            await Task.Run(() =>
            {

                Update("inFocus", inFocus? "1":"0", false);
                WhereEqual("box", box);
                WhereEqual("timeStarted", timeStarted.ToString());
                Execute(DatabasePermissions.All);
            });
        }
    }
}
