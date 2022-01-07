using Gtk;

namespace DriveApp.UI.Gtk;

public class MainWindow2 : Window
{
    public MainWindow2() : this(new Builder("MainWindow.glade"))
    {
    }

    private MainWindow2(Builder builder) : base(builder.GetRawOwnedObject("MainWindow2"))
    {
        builder.Autoconnect(this);

        DeleteEvent += Window_DeleteEvent;
    }

    private void Window_DeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
    }
}
