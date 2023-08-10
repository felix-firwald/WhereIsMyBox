using System.Data;
using System.Data.SqlClient;

namespace DatabaseRequests
{
    public static class DatabaseManager // static cause server connection must be only one per session
    {
        // класс реализован неправильно!
        // свойство "path" должно получаться из конфиг-файла,
        // а записываться туда при инициализации программы либо при установке
        readonly public static string path = @"server=DESKTOP-H74SD3A\SQLEXPRESS;Database=WhereIsMyBox;Integrated Security=true";
        readonly public static string password; // for mysql, will be terminated
        readonly public static string database; // for mysql, will be terminated
        readonly public static SqlConnection connection;
        public static void OpenConnection() // for mysql, will be terminated
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }
        public static void CloseConnection() // for mysql, will be terminated
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

