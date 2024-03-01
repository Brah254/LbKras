// TODO: copies files into nowhere?
//       then can't move same files there.
//       Probably didn't close the file or smth.
// TODO: test Delete functionality
// TODO: set temporary default textbox values for faster access

using System;
using System.IO;
using System.Windows.Forms;

namespace os_lab_2
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
