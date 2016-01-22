#region

using System;
using System.Windows.Forms;

#endregion

namespace SiebelReposAnalyser
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            //in windows forms you need also to add these two lines
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormReposAnalyser());
        }
    }
}