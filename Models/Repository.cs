﻿
using SQLite;

namespace PillMe.Models
{
    public class Repository
    {
        SQLiteConnection database;
        public Repository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Pill>();
            database.CreateTable<User>();
        }
        public IEnumerable<Pill> GetPills() =>
            database.Table<Pill>().ToList();
        public Pill GetPill(int id) =>
            database.Get<Pill>(id);
        public int DeletePill(int id) =>
            database.Delete<Pill>(id);
        public int SavePill(Pill item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            return database.Insert(item);
        }
        public IEnumerable<User> GetUsers() =>
            database.Table<User>().ToList();
        public User GetUser(int id) =>
            database.Get<User>(id);
        public int DeleteUser(int id) =>
            database.Delete<User>(id);
        public int SaveUser(User item)
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
