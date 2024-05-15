
using SQLite;

namespace PillMe.Models
{
    public class UserRepository
    {
        SQLiteConnection database;
        public UserRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<User>();
        }
        public IEnumerable<User> GetItems() =>
            database.Table<User>().ToList();
        public User GetItem(int id) =>
            database.Get<User>(id);
        public int DeleteItem(int id) =>
            database.Delete<User>(id);
        public int SaveItem(User item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            return database.Insert(item);
        }
    }
}
