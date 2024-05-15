using SQLite;

namespace PillMe.Models
{
    public class PillRepository
    {
        SQLiteConnection database;
        public PillRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Pill>();
        }
        public IEnumerable<Pill> GetItems() =>
            database.Table<Pill>().ToList();
        public Pill GetItem(int id) =>
            database.Get<Pill>(id);
        public int DeleteItem(int id) =>
            database.Delete<Pill>(id);
        public int SaveItem(Pill item)
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
