using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace StoreVersionUploader
{
    class StoreManager
    {
        private MainWindow window;
        private SQLiteClient sqlite;

        public StoreManager(MainWindow window)
        {
            this.window = window;
            this.sqlite = new SQLiteClient("package.db3");

            LoadProductsList(); LoadAPIKey();
        }

        public void AssignAPIKey()
        {
            string APIKey = string.Empty;
            string apiKeyPath = Utils.AppPath + "api_key";

            Utils.InvokeOn(window.txtbox_APIKeyInput, () => APIKey = window.txtbox_APIKeyInput.Text);
            if (APIKey.Length == 0) return;


            using(var stream = new FileStream(apiKeyPath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using(var writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    string temp = Convert.ToBase64String(Encoding.UTF8.GetBytes(APIKey));

                    writer.Write(temp);
                }
            }

            Utils.InvokeOn(window.txtbox_APIKeyInput, () => window.txtbox_APIKeyInput.Text = string.Empty);

            LoadAPIKey();
        }

        public void AddProduct()
        {
            string tempProductId = string.Empty, 
                   tempProductName = string.Empty, 
                   tempProductFolderPath = string.Empty;


            Utils.InvokeOn(window.txtbox_ProductIdInput, () => tempProductId = window.txtbox_ProductIdInput.Text);
            Utils.InvokeOn(window.txtbox_ProductNameInput, () => tempProductName = window.txtbox_ProductNameInput.Text);
            Utils.InvokeOn(window.txtbox_ProductFolderPathInput, () => tempProductFolderPath = window.txtbox_ProductFolderPathInput.Text);


            int productId = 0;
            string productName = string.Empty;


            if (Regex.IsMatch(tempProductId, @"^\d+$"))
            {
                try
                {
                    Int32.TryParse(tempProductId, out productId);
                }
                catch
                {
                    return;
                }
            }
            else return;


            if (tempProductName.Length != 0)
            {
                productName = tempProductName;
            }
            else return;



            string numQuery = String.Format("SELECT COUNT(product_id) FROM products WHERE product_id={0}", productId);

            if (sqlite.NumRows(sqlite.Command(numQuery)) > 0) return;
            


            string query = String.Format("INSERT INTO products (name, product_id, path) VALUES(@productName, '{0}', '{1}')", productId, tempProductFolderPath);

            var sqliteParams = new SQLiteParameter[]
            {
                new SQLiteParameter("@productName", productName)
            };


            if(sqlite.ExecuteCommand(sqlite.Command(query, sqliteParams)) > 0)
            {
                Utils.InvokeOn(window.txtbox_ProductNameInput, () => window.txtbox_ProductNameInput.Text = string.Empty);
                Utils.InvokeOn(window.txtbox_ProductIdInput, () => window.txtbox_ProductIdInput.Text = string.Empty);
                Utils.InvokeOn(window.txtbox_ProductFolderPathInput, () => window.txtbox_ProductFolderPathInput.Text = string.Empty);
            }


            LoadProductsList();
        }

        public bool DeleteProduct(int productId)
        {
            string query = String.Format("DELETE FROM products WHERE product_id={0}", productId);

            return (sqlite.ExecuteCommand(sqlite.Command(query)) > 0) ? true : false;
        }

        public void LoadProductsList()
        {
            SQLiteDataReader reader = sqlite.ExecuteReader(sqlite.Command("SELECT * FROM products ORDER BY id DESC"));

            var products = new List<Product>();

            while (reader.Read())
            {
                products.Add(new Product()
                {
                    id = reader.GetInt32(2), name = reader.GetString(1), path = reader.GetString(3)
                });
            }



            Utils.InvokeOn(window.dtg_ProductList, () =>
            {
                if (window.dtg_ProductList.Rows.Count > 0) window.dtg_ProductList.Rows.Clear();

                foreach (var product in products)
                {
                    window.dtg_ProductList.Rows.Add(product.id, product.name, product.path);
                }
            });
        }

        public void LoadAPIKey()
        {
            string APIKey = "Empty";
            string apiKeyPath = Utils.AppPath + "api_key";


            using (var stream = new FileStream(apiKeyPath, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (var reader = new StreamReader(stream, Encoding.UTF8))
                {
                    string temp = reader.ReadToEnd();

                    if (temp.Length != 0)
                    {
                        byte[] buffer = Convert.FromBase64CharArray(temp.ToCharArray(), 0, temp.Length);
                        APIKey = Encoding.UTF8.GetString(buffer);
                    }
                }
            }

            Utils.InvokeOn(window.txtbox_APIKey, () => window.txtbox_APIKey.Text = APIKey);
        }
    }
}
