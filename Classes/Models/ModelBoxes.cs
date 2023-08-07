using DatabaseRequests;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows;

namespace WhereIsMyBox.Classes.Models
{
    public enum BoxStatus
    {
        Available,
        Seized,
        Focused,
        Lost,
        Undefined
    }
    public sealed class ModelBoxes : Model
    {
        public string number { get; set; }
        public string location { get; set; }
        public BoxStatus status {
            get { return status; } 
            set { status = value; } 
        }
        public string type { get; set; }
        public string note { get; set; }
        public ModelBoxes() : base()
        {
            tableName = "Boxes";
        }
        #region NotSQL functions
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
        public BoxStatus GetEnumerableStatusOn(string key)
        {
            switch (key)
            {
                case "1":
                    return BoxStatus.Available;
                case "2":
                    return BoxStatus.Seized;
                case "3":
                    return BoxStatus.Focused;
                case "4":
                    return BoxStatus.Lost;
                default:
                    return BoxStatus.Undefined;
            }
        }
        public string GetSqlTypeOnEnumerableStatus(BoxStatus status)
        {
            switch (status)
            {
                case BoxStatus.Available: return "1";
                case BoxStatus.Seized: return "2";
                case BoxStatus.Focused: return "3";
                case BoxStatus.Lost: return "4";
                default: return "0";
            }
        }
        public string GetStringNameOfStatus()
        {
            switch (this.status)
            {
                case BoxStatus.Seized: case BoxStatus.Focused:
                    return "Изъят";
                case BoxStatus.Available: 
                    return "Доступен";
                case BoxStatus.Lost:
                    return "Не найден";
                default: return "Не определен";
            }
        }
        public bool SwitchAccessOnStatus()
        {
            switch (status)
            {
                case BoxStatus.Seized:
                case BoxStatus.Available:
                case BoxStatus.Lost:
                    return true;
                case BoxStatus.Focused: 
                default:
                    return false;
            }
        }
        #endregion

        #region Create
        public void AddBox()   // НЕ ДОПИСАНО!
        {
            if ((number??location) == null)
            {
                throw new Exception(
                    $"One or more of arguments for \"AddBox\" is null!\n" +
                    $"number={number}, location={location}"
                );
            }
            string status = GetSqlTypeOnEnumerableStatus(this.status);
            Insert(
                "number, location, status, type, note",
                $"'{this.number}', '{this.location}', {status}, '{this.type}', '{this.note}'"
            );
            Execute(DatabasePermissions.All);
        }
        #endregion

        #region Read
        public bool GetBoxByNumber(string num)
        {
            Select("*");
            WhereEqual("number", num);
            
            try
            {
                DataRow dr = GetOne(Execute(DatabasePermissions.All));
                Validate(dr);
                //number = dr["number"].ToString();
                //location = dr["location"].ToString();
                //status = GetEnumerableStatusOn(dr["status"].ToString());
                //type = dr["type"].ToString();
                //note = dr["note"].ToString();
                return true;
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool IsBoxCanUse(string num)
        {
            Select("status");
            WhereEqual("number", num);
            try
            {
                DataRow dr = GetOne(Execute(DatabasePermissions.All));
                this.status = GetEnumerableStatusOn(dr["status"].ToString());
                return SwitchAccessOnStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Невозможно выполнить операцию");
                return false;
            }
        }
        #endregion

        #region Update
        public async void UpdateStatus(BoxStatus onStatus)
        {
            await Task.Run(() =>
            {
                Update("status", this.GetSqlTypeOnEnumerableStatus(onStatus));
                WhereEqual("number", this.number);
                Execute(DatabasePermissions.All);
            });
        }
        #endregion
    }
}
