using System;
using Gtk;

namespace DriveApp.UI.Gtk
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Application.Init();

            var app = new Application("org.willemsens.DriveApp", GLib.ApplicationFlags.None);
            app.Register(GLib.Cancellable.Current);

            /*var win = new MainWindow();
            app.AddWindow(win);
            win.Show();*/

            var win2 = new MainWindow2();
            app.AddWindow(win2);
            win2.Show();

            Application.Run();
        }
    }
}
