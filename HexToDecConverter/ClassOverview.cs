using System;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace ConversionUtility
{
    class ClassOverview
    {
        private static Thread thread;
        private static string path = "";
        private const string file = "\\ClassOverview.htm";
        private static string filepath = "";

        private static void LoadWait()
        {
            new WaitFormLoading(filepath).ShowDialog();
        }

        public static void DisplayHtml()
        {
            if (Directory.Exists(Application.StartupPath + "\\Plugins"))
            {
                path = Application.StartupPath + "\\Plugins";
                filepath = path + file;
            }

            //Is this bad programming?
            thread = new Thread(LoadWait);
            thread.Start();

            Process.Start(filepath);
            thread.Abort();
        }
    }
}
