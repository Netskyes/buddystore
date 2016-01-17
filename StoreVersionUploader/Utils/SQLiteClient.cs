using System;
using System.IO;
using System.Data;
using System.Data.SQLite;


namespace StoreVersionUploader
{
    class SQLiteClient
    {
        private SQLiteConnection conn;

        public SQLiteClient(string dbName)
        {
            string DBPath = Utils.AppPath + dbName;
            bool tableRequired = false;


            if(!File.Exists(DBPath))
            {
                SQLiteConnection.CreateFile(DBPath);
                tableRequired = true;
            }
            

            conn = new SQLiteConnection(@String.Format("Data Source={0};Version=3", DBPath));
            conn.Open();


            if (tableRequired) Defaults();
        }

        private void Defaults()
        {
            string productsQuery = "CREATE TABLE products (id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT NOT NULL, product_id INTEGER NOT NULL UNIQUE, path TEXT, api_key TEXT);";
            ExecuteCommand(Command(productsQuery));
        }


        public SQLiteCommand Command(string query, SQLiteParameter[] queryParams = null)
        {
            SQLiteCommand command = conn.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = query;


            if(queryParams != null)
            {
                command.Parameters.AddRange(queryParams);
            }

            return command;
        }

        public int ExecuteCommand(SQLiteCommand command)
        {
            return command.ExecuteNonQuery();
        }

        public SQLiteDataReader ExecuteReader(SQLiteCommand command)
        {
            return command.ExecuteReader();
        }

        public int NumRows(SQLiteCommand command)
        {
            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
