
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

    public struct Column
    {
        public Model table;
        public string name;
        public string type;
        public string defaultValue;
        public Model foreignKey;
        public bool autoincrement;
        public bool isNull;
        public bool uniq;

        public override string ToString()
        {
            return $"{table}.{name}";
        }
        public string CreateString()
        {
            string resultDefault = "";
            if (defaultValue.Length > 0)
            {
                resultDefault = $" DEFAULT '{defaultValue}'";
            }
            string foreign = "";
            if (foreignKey != null)
            {
                foreign = $" FOREIGN KEY ({name}) REFERENCES {foreignKey}(id)";
            }
            string resultNull = "";
            if (!isNull)
            {
                resultNull = " NOT NULL";
            }
            string unique = "";
            if (uniq)
            {
                unique = " UNIQUE";
            }
            string ai = "";
            if (autoincrement)
            {
                ai = " AUTO_INCREMENT";
            }
            return $"{name} {type.ToUpper()}{foreign}{ai}{resultDefault}{resultNull}{unique}";
        }
        public Column(
            Model tableName,
            string columnName,
            string typeOfColumn,
            bool nullVal,
            bool uniqVal,
            String defaultVal,
            bool autoIncrement = false,
            Model foreign = null) : this()
        {
            this.table = tableName;
            name = columnName;
            type = typeOfColumn;
            foreignKey = foreign;
            autoincrement = autoIncrement;
            defaultValue = defaultVal;
            isNull = nullVal;
            uniq = uniqVal;
        }
    }
    /// <summary>
    /// RValue структура нужна для правильного отображения данных в зависимости от их типа
    /// </summary>
    public struct RValue
    {
        public Types type;
        public string value;
        public override string ToString()
        {
            switch (type)
            {
                case Types.INT:
                    return value;
                case Types.STR:
                    return $"'{value}'";
                default:
                    throw new Exception($"Unknow type for RValue: {type}");
            }
        }
        public RValue(string val, Types typ = Types.STR) : this()
        {
            type = typ;
            value = val;
        }
    }
    public abstract class Model
    {
        private string result;
        private bool isWhereAlready;
        protected string tableName;
        public List<Column> columns = new List<Column>(12);
        public Model()
        {
            result = "";
            isWhereAlready = false;
        }
        public override string ToString()
        {
            return tableName;
        }
        private string SwitchOnType(Types type = Types.STR)
        {
            switch (type)
            {
                case Types.STR:
                    return "'";
                case Types.INT:
                    return "";
            }
            return "'";
        }
        /// <summary>
        /// Добавить столбец в бд. Необходимо применять перед вызовом метода CreateTable().
        /// Например:   Request.AddColumn(name, type, true).CreateTable().Execute()
        /// </summary>
        public void AddColumn(string name, string type, bool isNull = false, bool isUniq = false, string defaultValue = "", Model foreign = null)
        {
            this.columns.Append(
                new Column(
                    tableName: this,
                    columnName: name,
                    typeOfColumn: type,
                    nullVal: isNull,
                    uniqVal: isUniq,
                    defaultVal: defaultValue,
                    foreign: foreign
                    )
            );
        }
        /// <summary>
        /// Сгенерирует запрос к базе данных о создании таблицы, для выполнения запроса применить Execute().
        /// Например:   Request.CreateTable().Execute()
        /// </summary>
        public Model CreateTable()
        {
            string res = "";
            int count = 0;
            foreach (Column col in columns)
            {
                if (count != 0)
                {
                    res += ", ";
                }
                count++;
                res += col.ToString();
            }
            result = $"CREATE TABLE {tableName}({res})";
            return this;
        }

        public Model Select(string selection)
        {
            string resulting;
            resulting = $"SELECT {selection}\nFROM {tableName}\n";
            result = resulting;
            return this;
        }

        public Model Insert(RValue[] args)
        {
            string resulting;
            resulting = $"INSERT INTO {tableName}\nVALUES (";
            if (args.Length == 1)
            {
                resulting += args[0].ToString();
            }
            else
            {
                int count = 0;
                foreach (var arg in args)
                {
                    if (count != 0)
                    {
                        resulting += ", ";
                    }
                    count++;
                    resulting += arg.ToString();
                }
            }
            resulting += ")\n";
            result = resulting;
            return this;
        }

        public Model InnerJoin(Model innerTable, string fieldBaseTable, string fieldJoinedTable)
        {
            string resulting;
            resulting = result + $"INNER JOIN {innerTable}\nON {tableName}.{fieldBaseTable}={innerTable}.{fieldJoinedTable}\n";
            result = resulting;
            return this;
        }

        private Model Where(string cell, string comparator, string value)
        {
            string resulting;
            // String s = SwitchOnType(type);
            if (isWhereAlready)
            {
                resulting = result + $" AND {cell} {comparator} {value}\n";
                result = resulting;
                return this;
            }
            else
            {
                isWhereAlready = true;
                resulting = result + $"WHERE {cell} {comparator} {value}\n";
                result = resulting;
                return this;
            }

        }

        public Model WhereEqual(String cell, RValue value)
        // Where A (left arg) = B (right arg)
        {
            return Where(cell, "=", value.ToString());
        }
        public Model WhereNotEqual(String cell, RValue value)
        // Where A (left arg) != B (right arg)
        {
            return Where(cell, "<>", value.ToString());
        }
        public Model WhereLess(String cell, RValue value)
        // Where A (left arg) < B (right arg)
        {
            return Where(cell, "<", value.ToString());
        }
        public Model WhereMore(String cell, RValue value)
        // Where A (left arg) > B (right arg)
        {
            return Where(cell, ">", value.ToString());
        }
        public Model WhereBetween(String cell, RValue valueA, RValue valueB)
        // Where A (left arg) BETWEEN B (central arg) AND C (right arg)
        {
            String a = valueA.ToString();
            String b = valueB.ToString();
            return Where(cell, "BETWEEN", $"{a} AND {b}");
        }
        public Model WhereIn(String cell, string[] args, Types type = Types.STR)
        // Where A (left arg) IN (args)
        {
            String s = SwitchOnType(type);
            String resultingString = "(";
            if (args.Length == 1)
            {
                resultingString += $"{s}{args[0]}{s}";
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
                    resultingString += $"{s}{arg}{s}";
                }
            }
            resultingString += ")\n";
            return Where(cell, "IN", resultingString);
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
        protected string GetRequest()
        {
            string tmp = result;
            Clear();
            return tmp;
        }
        protected void Clear()
        {
            result = "";
        }
        protected bool CheckPermission(DatabasePermissions permission)
        {
            switch(permission) 
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

