namespace CRMBackend.Data.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int AdminWiseUsersId { get; set; }
        public AdminWiseUsers AdminWiseUsers { get; set; }

    }
}
