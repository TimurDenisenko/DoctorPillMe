using SQLite;

namespace PillMe.Models
{
    [Table("Pills")]
    public class Pill
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount {  get; set; } 
        public decimal Price { get; set; }
    }
}
