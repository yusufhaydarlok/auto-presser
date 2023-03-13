using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace auto_presser.Auto_Clicker.User32ApiUtils
{
    public static class User32ApiUtils
    {
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        public static extern bool SetCursorPosition(int x, int y);
        [DllImport("user32.dll")]
        public static extern void ExecuteMouseEvent(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
    }
}
