using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace StoreVersionUploader
{
    class StoreUploader
    {
        private MainWindow window;

        public StoreUploader(MainWindow window)
        {
            this.window = window;
        }

        public void Execute(StoreOptions options)
        {
            Utils.InvokeOn(window.txtbox_APIKey, () => options.ApiKey = window.txtbox_APIKey.Text);
            Utils.InvokeOn(window.txtbox_Changelog, () => options.Changelog = window.txtbox_Changelog.Text);
            Utils.InvokeOn(window.cmbox_VersionType, () => options.VersionType = window.cmbox_VersionType.Text);
            Utils.InvokeOn(window.txtbox_Version, () => options.Version = window.txtbox_Version.Text);
            Utils.InvokeOn(window.txtbox_ProductId, () => options.ProductId = Convert.ToInt32(window.txtbox_ProductId.Text));


            Task.Run(() => UploadProduct(options)); window.UploadButtonUpdate("^.^", false);
        }


        private void UploadProduct(StoreOptions options)
        {
            Log("Uploading...");

            try
            {
                using (var webclient = new WebClient())
                {
                    webclient.UploadProgressChanged += Webclient_UploadProgressChanged;
                    webclient.UploadStringCompleted += Webclient_UploadStringCompleted;

                    webclient.Headers[HttpRequestHeader.ContentType] = "application/json";
                    webclient.UploadStringAsync(new Uri("https://store.buddyauth.com:8337/api/restapi/submitversion"), JsonConvert.SerializeObject(options));
                }

                Log("Product successfully uploaded, compiling...");
            }
            catch (WebException wex)
            {
                Log("Something went wrong!");

                if (wex.Status == WebExceptionStatus.ProtocolError && wex.Response.GetResponseStream() != null)
                {
                    var serializer = new JsonSerializer();

                    // ReSharper disable once AssignNullToNotNullAttribute
                    using (var sr = new StreamReader(wex.Response.GetResponseStream()))
                    using (var jsonTextReader = new JsonTextReader(sr))
                    {
                        serializer.Deserialize(jsonTextReader);
                    }
                }
                else
                {
                    Log(wex.ToString());
                }
            }
        }


        private void Webclient_UploadStringCompleted(object sender, UploadStringCompletedEventArgs e)
        {
            Log("Product submission successfull!"); window.UploadButtonUpdate("Upload", true);
        }

        private void Webclient_UploadProgressChanged(object sender, UploadProgressChangedEventArgs e)
        {
            Utils.InvokeOn(window.pbar_UploadProgress, () => window.pbar_UploadProgress.Value = e.ProgressPercentage);
        }

        private void Log(string text)
        {
            Utils.InvokeOn(window.txtbox_Console, () =>
            {
                window.txtbox_Console.AppendText(text + Environment.NewLine);
            });
        }
    }
}
