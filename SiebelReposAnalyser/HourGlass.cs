using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SiebelReposAnalyser
{
    public class HourGlass : IDisposable
    {
        public HourGlass()
        {
            Enabled = true;
        }

        public static bool Enabled
        {
            get { return Application.UseWaitCursor; }
            set
            {
                if (value == Application.UseWaitCursor) return;
                Application.UseWaitCursor = value;
                Form f = Form.ActiveForm;
                if (f != null && f.Handle != IntPtr.Zero) // Send WM_SETCURSOR
                    SendMessage(f.Handle, 0x20, f.Handle, (IntPtr) 1);
            }
        }

        public void Dispose()
        {
            Enabled = false;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);
    }
}