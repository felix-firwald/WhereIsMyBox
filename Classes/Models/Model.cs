
using DatabaseRequests;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
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
    public static class DatabaseManager
    {
        // Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        readonly public static string path = @"server=DESKTOP-H74SD3A\SQLEXPRESS;Database=WhereIsMyBox;Integrated Security=true";
        readonly public static string password; // удалить если будет не нужно
        readonly public static string database; // удалить если будет не нужно
        readonly public static SqlConnection connection;
        public static void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
    public enum Types
    {
        INT,
        STR
    }
    /// <summary>
    /// RValue структура нужна для правильного отображения данных в зависимости от их типа
    /// </summary>
    public abstract class Model
    {
        private string result;
        private bool isWhereAlready;
        protected string tableName;
        public Model()
        {
            result = "";
            isWhereAlready = false;
        }
        public override string ToString()
        {
            return tableName;
        }
        /// <summary>
        /// Добавить столбец в бд. Необходимо применять перед вызовом метода CreateTable().
        /// Например:   Request.AddColumn(name, type, true).CreateTable().Execute()
        /// </summary>

        /// <summary>
        /// Сгенерирует запрос к базе данных о создании таблицы, для выполнения запроса применить Execute().
        /// Например:   Request.CreateTable().Execute()
        /// </summary>
        public Model Select(string selection)
        {
            string resulting;
            resulting = $"SELECT {selection}\nFROM {tableName}\n";
            result = resulting;
            return this;
        }

        public Model Insert(string fields, string values)
        {
            result += $"INSERT INTO {tableName} ({fields})\nVALUES ({values})";
            return this;
        }

        public Model InnerJoin(Model innerTable, string fieldBaseTable, string fieldJoinedTable)
        {
            string resulting;
            resulting = result + $"INNER JOIN {innerTable}\nON {tableName}.{fieldBaseTable}={innerTable}.{fieldJoinedTable}\n";
            result = resulting;
            return this;
        }

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
                resulting = result + $"WHERE {cell} {comparator} {c}{value}{c}\n";
                result = resulting;
                return this;
            }

        }
        protected Model Delete()
        {
            result += $"DELETE FROM {this.tableName}\n";
            return this;
        }

        public Model WhereEqual(string cell, string value, bool isStr=true)
        // Where A (left arg) = B (right arg)
        {
            return Where(cell, "=", value, isStr);
        }
        public Model WhereNotEqual(string cell, string value, bool isStr = true)
        // Where A (left arg) != B (right arg)
        {
            return Where(cell, "<>", value, isStr);
        }
        public Model WhereLess(string cell, string value, bool isStr = true)
        // Where A (left arg) < B (right arg)
        {
            return Where(cell, "<", value, isStr);
        }
        public Model WhereMore(string cell, string value, bool isStr = true)
        // Where A (left arg) > B (right arg)
        {
            return Where(cell, ">", value, isStr);
        }
        public Model WhereBetween(string cell, string left, string right, bool isStr = true)
        // Where A (left arg) BETWEEN B (central arg) AND C (right arg)
        {
            return Where(cell, "BETWEEN", $"{left} AND {right}", isStr);
        }
        public Model WhereIn(String cell, string[] args)
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
        /// <summary>
        /// Возвращает MySqlConnection с подставленными значениями, предварительно проверяя доступ
        /// </summary>
        /// <returns></returns>
        protected SqlConnection GetConnection(DatabasePermissions permission, [CallerMemberName] string callerName = "")
        {
            if (!CheckPermission(permission))
            {
                throw new Exception(
                    $"Access denied: this user can`t call \"{callerName}\" " +
                    $"for table \"{tableName}\", because is not a member of \"{permission}\" permission role."
                );
            }
            return new SqlConnection(
            DatabaseManager.path);
        }
        protected string GetRequest(bool clear=true)
        {
            string tmp = result;
            if (clear)
            {
                Clear();
            }
            return tmp;
        }
        protected void Clear()
        {
            result = "";
        }
        protected bool CheckPermission(DatabasePermissions permission)
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

    }
}

