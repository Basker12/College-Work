using System;
using Microsoft.Data.Sqlite;

namespace WebApplication.Data
{
    public class dbConnection
    {
        public static SqliteConnection CreateConnection(string dbLocation)
        {
            SqliteConnection connection =
                new SqliteConnection("Data Source=" + dbLocation + ";Version=3;New=True;Compress=True;");

            try
            {
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return connection;
        }
    }
}