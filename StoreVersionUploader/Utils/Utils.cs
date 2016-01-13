using System;
using System.Windows.Forms;

namespace StoreVersionUploader
{
    internal class Utils
    {
        public static void InvokeOn(Control ctl, Action action)
        {
            if (ctl != null)
            {
                if (ctl.InvokeRequired)
                {
                    ctl.Invoke(new Action(() => InvokeOn(ctl, action)));
                }
                else action();
            }
        }

        public static string AppPath
        {
            get
            {
                return Application.StartupPath + @"\";
            }
        }
    }
}
