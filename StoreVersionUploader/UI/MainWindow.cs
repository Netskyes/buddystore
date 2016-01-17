using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace StoreVersionUploader
{
    public partial class MainWindow : Form
    {
        private bool isWindowLoaded = false;

        private StoreManager storeManager;
        private StoreUploader storeUploader;
        private StoreOptions storeOptions;

        private string defaultFolderPath = string.Empty;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            storeManager = new StoreManager(this); storeUploader = new StoreUploader(this); storeOptions = new StoreOptions();

            // Defaults
            cmbox_VersionType.SelectedIndex = 1;
            isWindowLoaded = true;

            txtbox_Console.AppendText("Store Version Uploader 1.0.3" + Environment.NewLine);
        }




        // MAIN INPUT //
        public void UploadButtonUpdate(string text, bool state)
        {
            Utils.InvokeOn(btn_Upload, () =>
            {
                btn_Upload.Enabled = state; btn_Upload.Text = text;
            });
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            storeUploader.Execute(storeOptions);
        }

        private void btn_ZipFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
                           dialog.InitialDirectory = defaultFolderPath;


            if(dialog.ShowDialog() == DialogResult.OK)
            {
                storeOptions.Path = dialog.FileName;


                Utils.InvokeOn(txtbox_ProductZipFile, () => txtbox_ProductZipFile.Text = Path.GetFileName(dialog.FileName));

                Utils.InvokeOn(txtbox_Version, () =>
                {
                    Match match = new Regex(@"([0-9\.]+)").Match(Path.GetFileNameWithoutExtension(dialog.FileName));

                    if (txtbox_Version.Text.Length == 0) txtbox_Version.Text = match.Value;
                });
            }
        }
        // MAIN INPUT //






        // STORE MANAGER //
        private void btn_AssignAPIKey_Click(object sender, EventArgs e)
        {
            storeManager.AssignAPIKey();
        }

        private void btn_AddProductName_Click(object sender, EventArgs e)
        {
            storeManager.AddProduct();
        }

        private void btn_FolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtbox_ProductFolderPathInput.Text = dialog.SelectedPath;
            }
        }

        private void dtg_ProductList_SelectionChanged(object sender, EventArgs e)
        {
            dtg_ProductList.ClearSelection();
        }

        private void cmbox_ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!isWindowLoaded) return;
        }

        private int RowIndex = -1;

        private void dtg_ProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtg_ProductList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                RowIndex = e.RowIndex;

                ContextMenu menu = new ContextMenu();
                var use = menu.MenuItems.Add("Use");
                var del = menu.MenuItems.Add("Delete");

                use.Click += Use_Click;
                del.Click += Del_Click;

                menu.Show(this, PointToClient(Cursor.Position), LeftRightAlignment.Right);
            }
        }

        private void Use_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtg_ProductList.Rows[RowIndex];


            Utils.InvokeOn(txtbox_ProductId, () => txtbox_ProductId.Text = row.Cells[0].Value.ToString());
            Utils.InvokeOn(txtbox_ProductName, () => txtbox_ProductName.Text = row.Cells[1].Value.ToString());

            defaultFolderPath = row.Cells[2].Value.ToString();


            tabControl.SelectedIndex = 0;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dtg_ProductList.Rows[RowIndex];
            
            int productId = Convert.ToInt32(row.Cells[0].Value);

            if(storeManager.DeleteProduct(productId))
            {
                dtg_ProductList.Rows.Remove(row);
            }
            else
            {
                MessageBox.Show("An error occured when deleting an entry.");
            }
        }
        // STORE MANAGER //
    }
}
