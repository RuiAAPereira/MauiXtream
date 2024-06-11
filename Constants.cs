using SQLite;

namespace MauiXtream;
public static class Constants
{
    private const string _databaseName = "Data.db3";

    public const SQLiteOpenFlags Flags =
        SQLiteOpenFlags.ReadWrite |
        SQLiteOpenFlags.Create |
        SQLiteOpenFlags.SharedCache;


    public static string DatabasePath
    {

        get
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), _databaseName);
        }
    }
}