using System;
using System.Runtime.InteropServices;

namespace WinFormsApp_OOP_Lab1.Exceptions
{
    public class ExceptionHandler
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(
        IntPtr hWnd,
        string text,
        string caption,
        uint type);
    }
}
