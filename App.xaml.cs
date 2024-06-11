using MauiXtream.Data;

namespace MauiXtream;

public partial class App : Application
{
    static SQLiteData _connection;
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
