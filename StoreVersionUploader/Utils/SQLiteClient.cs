using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

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
            Execute(productsQuery);

            /*
            string apikeysQuery = "CREATE TABLE api_keys (id INTEGER PRIMARY KEY AUTOINCREMENT, key	TEXT NOT NULL UNIQUE);";
            Execute(apikeysQuery);
            */
        }


        public int Execute(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, conn);
            return command.ExecuteNonQuery();
        }

        public SQLiteDataReader ExecuteReader(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, conn);
            return command.ExecuteReader();
        }

        public int NumRows(string query)
        {
            SQLiteCommand command = new SQLiteCommand(query, conn);

            return Convert.ToInt32(command.ExecuteScalar());
        }
    }
}
