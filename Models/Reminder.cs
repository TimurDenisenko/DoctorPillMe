
namespace PillMe.Models
{
    public class Reminder
    {
        public string User { get; set; }
        public Pill MyPill { get; set; }
        public int Count { get; set; }
        public TimeOnly Time { get; set; }
        public DayOfWeek Day { get; set; }
    }
}
