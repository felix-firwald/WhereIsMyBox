using DatabaseRequests;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WhereIsMyBox.Classes.Models
{
    public sealed class ModelUsing : Model
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

        #region Create
        public async void AddBoxIntoUsing(int minutes = 60)   // ДОБАВИТЬ обращение к Boxes, изменение статуса на "изъят"
        {
            await Task.Run(() =>
            {
                using (ModelBoxes boxUse = new ModelBoxes())
                {

                }
                timeStarted = DateTime.Now;
                timeFinished = DateTime.Now.AddMinutes(minutes);
                int focus = Convert.ToInt32(inFocus);
                Insert(
                    "box, place, customer, timeStarted, timeFinished, inFocus, finished",
                    $"'{box}', '{place}', '{customer}', '{timeStarted}', '{timeFinished}', {focus}, 0"
                );
                Execute(DatabasePermissions.All);
                UpdateBoxStatus(BoxStatus.Seized);
            });
        }
        #endregion

        #region Read
        public bool GetUsingByBox(string number)
        {
            Select("*");
            WhereEqual("box", number);
            WhereEqual("finished", "0");
            OrderByDESC("timeStarted");
            try
            {
                DataRow dr = GetOne(Execute(DatabasePermissions.All));
                this.id = (int)dr["id"];
                this.box = dr["box"].ToString();
                this.place = dr["place"].ToString();
                this.customer = dr["customer"].ToString();
                this.timeStarted = (DateTime)dr["timeStarted"];
                this.timeFinished = (DateTime)dr["timeFinished"];
                this.inFocus = (bool)dr["inFocus"];
                this.finished = (bool)dr["finished"];
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка выполнения операции");
                return false;
            }
        }
        #endregion

        #region Update
        private void UpdateBoxStatus(BoxStatus onStatus)
        {
            ModelBoxes updateBox = new ModelBoxes();
            updateBox.number = this.box;
            updateBox.UpdateStatus(onStatus);
        }
        public async void ReturnSeizing()
        {
            await Task.Run(() =>
            {
                Update("finished", "1", false);
                Update("timeFinished", DateTime.Now.ToString());
                WhereEqual("box", this.box);
                WhereEqual("timeStarted", timeStarted.ToString());
                Execute(DatabasePermissions.All);
                UpdateBoxStatus(BoxStatus.Available);
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
                if (inFocus)
                {
                    UpdateBoxStatus(BoxStatus.Focused);
                }
                else
                {
                    UpdateBoxStatus(BoxStatus.Seized);
                }
            });
        }
        #endregion

    }
}
