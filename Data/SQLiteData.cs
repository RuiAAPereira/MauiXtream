using MauiXtream.Models;
using SQLite;

namespace MauiXtream.Data;
public class SQLiteData
{
    readonly SQLiteAsyncConnection _connection;

    public UserData UserDataTable { get; set; }

    public SQLiteData(string path)
    {
        _connection = new SQLiteAsyncConnection(path);
        _connection.CreateTableAsync<User>().Wait();

        UserDataTable = new UserData(_connection);
    }
}
