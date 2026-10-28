
using LoginForm41;
using System;
using System.Windows.Forms;

namespace LoginForm41
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
