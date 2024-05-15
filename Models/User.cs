
using SQLite;

namespace PillMe.Models
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string HashPassword { get; set; }
    }
}
