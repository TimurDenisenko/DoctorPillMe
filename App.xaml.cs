using PillMe.Models;
using PillMe.Views;

namespace PillMe
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "pills.db";
        public static PillRepository database;
        public static PillRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new PillRepository(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            MainPage = new Shell
            {
                CurrentItem = new PillListPage()
            };
        }
    }
}
