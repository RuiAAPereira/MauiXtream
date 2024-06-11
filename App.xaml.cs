using MauiXtream.Data;
using MauiXtream.Models;

namespace MauiXtream;

public partial class App : Application
{
    static SQLiteData? _database;

    public static SQLiteData Database
    {
        get
        {
            _database ??= new SQLiteData(Constants.DatabasePath);
            return _database;
        }
    }

    public static User? User { get; set; }

    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
