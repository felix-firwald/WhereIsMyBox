﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows;
using WhereIsMyBox.Classes;

namespace DatabaseRequests
{
    public enum DatabasePermissions
    {
        All,
        AdminOnly,
        ModeratorAndAdmin,
        ModeratorOnly,
        ModeratorAndOperator,
        OperatorOnly
    }
    public enum Types
    {
        INT,
        STR
    }

    public class InvalidIstructionException : Exception 
    {
        public InvalidIstructionException(string message) : base(message) 
        {

        }
    }

    public abstract class Model : System.IDisposable
    {
        private bool disposed = false;

        protected string tableName;

        #region Procedural Context
        private string result;
        private bool isWhereAlready;
        private bool isUpdateAlready;
        #endregion

        public Model()
        {
            Clear();
            GetFields(); // потом удалить!
        }
        public override string ToString()
        {
            return tableName;
        }
        #region Service
        public void Dispose()
        {
            CleanUp(true);
            GC.SuppressFinalize(this);
        }
        private void CleanUp(bool clean)
        {
            if (!this.disposed)
            {
                if (clean)
                {
                    this.disposed = true;
                }
            }
        }
        public void Clear()
        {
            isWhereAlready = false;
            isUpdateAlready = false;
            result = "";
        }
        private void ValidateInstruction()
        {
            string[] checkList = { "SELECT", "UPDATE", "DELETE" };
            bool isHavingWhere = this.result.Contains("WHERE");
            foreach (string checkItem in checkList)
            {
                if (this.result.Contains(checkItem))
                {
                    if (!isHavingWhere)
                    {
                        throw new InvalidIstructionException($"WHERE instruction is required for \"{this.result}\"");
                    }
                }
            }
            if (isHavingWhere)
            {
                foreach (string checkItem in checkList)
                {
                    if (this.result.Contains(checkItem))
                    {
                        return;
                    }
                }
                throw new InvalidIstructionException($"WHERE statement without RUD: \"{this.result}\"");
            }
            
        }
        protected List<string> GetFields()
        {
            List<string> result = new List<string>();
            foreach (var prop in this.GetType().GetProperties())
            {
                result.Add(prop.Name);
                Console.WriteLine(prop.Name, prop.DeclaringType);
            }
            return result;
        }
        #endregion

        #region Select-Insert-Update-Delete
        protected Model Select(string selection)
        {
            string resulting;
            resulting = $"SELECT {selection}\nFROM {tableName}\n";
            result = resulting;
            return this;
        }

        protected Model Insert(string fields, string values)
        {
            result += $"INSERT INTO {tableName} ({fields})\nVALUES ({values})";
            return this;
        }
        protected Model Update(string cell, string value, bool isStr=true)
        {
            string c = "'";
            if (!isStr) { c = ""; }
            if (isUpdateAlready)
            {
                result += $",\n" +
                $"{cell}={c}{value}{c}";
            }
            else
            {
                result += $"UPDATE {tableName}\n" +
                $"SET {cell}={c}{value}{c}";
                isUpdateAlready = true;
            }
            return this;
        }
        protected Model Delete()
        {
            result += $"DELETE FROM {this.tableName}\n";
            return this;
        }
        #endregion

        #region Join
        protected Model InnerJoin(Model innerTable, string fieldBaseTable, string fieldJoinedTable)
        {
            string resulting;
            resulting = result + $"INNER JOIN {innerTable}\nON {tableName}.{fieldBaseTable}={innerTable}.{fieldJoinedTable}\n";
            result = resulting;
            return this;
        }
        #endregion

        #region Where
        private Model Where(string cell, string comparator, string value, bool isStr)
        {
            string resulting;
            string c = "";
            if (isStr) 
            {
                c = "'";
            }
            if (isWhereAlready)
            {
                resulting = result + $" AND {cell} {comparator} {c}{value}{c}\n";
                result = resulting;
                return this;
            }
            else
            {
                isWhereAlready = true;
                resulting = result + $"\nWHERE {cell} {comparator} {c}{value}{c}\n";
                result = resulting;
                return this;
            }

        }

        protected Model WhereEqual(string cell, string value, bool isStr=true)
        // Where A (left arg) = B (right arg)
        {
            return Where(cell, "=", value, isStr);
        }
        protected Model WhereNotEqual(string cell, string value, bool isStr = true)
        // Where A (left arg) != B (right arg)
        {
            return Where(cell, "<>", value, isStr);
        }
        protected Model WhereLess(string cell, string value, bool isStr = true)
        // Where A (left arg) < B (right arg)
        {
            return Where(cell, "<", value, isStr);
        }
        protected Model WhereMore(string cell, string value, bool isStr = true)
        // Where A (left arg) > B (right arg)
        {
            return Where(cell, ">", value, isStr);
        }
        protected Model WhereBetween(string cell, string left, string right, bool isStr = true)
        // Where A (left arg) BETWEEN B (central arg) AND C (right arg)
        {
            return Where(cell, "BETWEEN", $"{left} AND {right}", isStr);
        }
        protected Model WhereIn(String cell, string[] args)
        // Where A (left arg) IN (args)
        {
            String resultingString = "(";
            if (args.Length == 1)
            {
                resultingString += $"'{args[0]}'";
            }
            else
            {
                int count = 0;
                foreach (var arg in args)
                {
                    if (count != 0)
                    {
                        resultingString += ", ";
                    }
                    count++;
                    resultingString += $"'{arg}'";
                }
            }
            resultingString += ")\n";
            return Where(cell, "IN", resultingString, false);
        }
        #endregion

        #region Order By
        private void OrderBy(string columns, string type)
        {
            this.result += $"\nORDER BY {columns} {type}";
        }
        protected Model OrderByASC(string columns)
        {
            OrderBy(columns, "ASC");
            return this;
        }
        protected Model OrderByDESC(string columns)
        {
            OrderBy(columns, "DESC");
            return this;
        }
        #endregion

        #region Connection, Request and Permission
        /// <summary>
        /// Возвращает SqlConnection с подставленными значениями, предварительно проверяя доступ
        /// </summary>
        /// <returns></returns>
        private SqlConnection GetConnection()
        {
            return new SqlConnection(DatabaseManager.path);
        }
        private string GetRequest(bool clear=true)
        {
            string tmp = result;
            Console.WriteLine(tmp);
            if (clear)
            {
                Clear();
            }
            return tmp;
        }
        private bool CheckPermission(DatabasePermissions permission)
        {
            switch (permission)
            {
                case DatabasePermissions.All: return true;
                case DatabasePermissions.AdminOnly:
                    return Permission.IsUserHavePermission(PermissionGroup.Admin, PermissionMode.Monopoly);
                case DatabasePermissions.ModeratorAndAdmin:
                    return Permission.IsUserHavePermission(PermissionGroup.Moderator, PermissionMode.Rising);
                case DatabasePermissions.ModeratorOnly:
                    return Permission.IsUserHavePermission(PermissionGroup.Moderator, PermissionMode.Monopoly);
                case DatabasePermissions.ModeratorAndOperator:
                    return Permission.IsUserHavePermission(PermissionGroup.Moderator, PermissionMode.Cascade);
                case DatabasePermissions.OperatorOnly:
                    return Permission.IsUserHavePermission(PermissionGroup.Operator, PermissionMode.Monopoly);
                default: throw new Exception($"Unknown permission type \"{permission}\" got.");
            }
        }
        protected DataTable Execute(DatabasePermissions permission, [CallerMemberName] string callerName = "")
        {
            ValidateInstruction();
            if (!CheckPermission(permission))
            {
                throw new Exception(
                    $"Access denied: this user can`t call \"{callerName}\" " +
                    $"for table \"{tableName}\", because is not a member of \"{permission}\" permission role."
                );
            }
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = GetRequest();
                    SqlDataReader sqlreader = cmd.ExecuteReader();
                    DataTable objDataTable = new DataTable();
                    objDataTable.Load(sqlreader);
                    return objDataTable;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"При выполнении запроса к базе данных возникла ошибка:\n{ex}" +
                    $"\nПроверьте правильность данных.",
                    "Ошибка выполнения запроса",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return new DataTable();
            }
        }

        /// <summary>
        /// Does not support custom types and sets such fields to null
        /// </summary>
        protected void Validate(DataRow dr)
        {
            foreach (var property in this.GetType().GetProperties())
            {
                try
                {
                    //if (Attribute.IsDefined(property, typeof(CreateOnValidate)))
                    //{
                    //    Type T = property.PropertyType;
                    //    var constructors = T.GetConstructors(System.Reflection.BindingFlags.Public);
                    //    constructors[0].Invoke(new object);
                    //    property.SetValue(this, Activator.CreateInstance(T).);
                    //}
                    property.SetValue(this, Convert.ChangeType(dr[property.Name], property.PropertyType)); // берет из datarow по названию переменной столбец и устанавливает значение к свойству
                    Console.WriteLine($"{property.Name} = {property.GetValue(this)}, ТИП: {property.PropertyType}");
                }
                catch (Exception)
                {
                    property.SetValue(this, null);
                    continue;
                }
            }
        }
        #endregion
        
        protected DataRow GetOne(DataTable dt)
        {
            return dt.Rows[0];
        }

    }
}

