using System;
using System.Windows.Forms;

namespace CharacterCountWinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize(); // .NET 6+ helper for visual styles / DPI
            Application.Run(new MainForm());
        }
    }
}