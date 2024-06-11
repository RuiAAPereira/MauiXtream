using MauiXtream.Models;
using SQLite;

namespace MauiXtream.Data;
public class UserData(SQLiteAsyncConnection connection)
{
    private readonly SQLiteAsyncConnection _connection = connection;

    public async Task<List<User>> GetUsersAsync()
    {
        return await _connection.Table<User>().ToListAsync();
    }

    public async Task<User> GetUserAsync(Guid id)
    {
        return await _connection.Table<User>().FirstOrDefaultAsync(
            u => u.Id == id);
    }

    public async Task<User> GetUserAsync(string userName, string password)
    {
        return await _connection.Table<User>().FirstOrDefaultAsync(
            u => u.UserName == userName && u.Password == password);
    }

    public async Task<int> SaveUserAsync(User user)
    {
        bool exists = GetUserAsync(user.Id).Result != null;
        if (exists)
        {
            return await _connection.UpdateAsync(user);
        }
        else
        {
            return await _connection.InsertAsync(user);
        }
    }

    public async Task<int> DeleteUserAsync(User user)
    {
        return await _connection.DeleteAsync(user);
    }
}
