namespace CRMBackend.Data.Models
{
    public class UserSMS
    {
        public int Id { get; set; }
        public int AdminWiseUsersId { get; set; }
        public AdminWiseUsers? AdminWiseUsers { get; set; }
        public ICollection<Recipients>? Recipients { get; set; }
    }
}
