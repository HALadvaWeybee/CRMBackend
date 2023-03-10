using CRMBackend.Models;

namespace CRMBackend.Data.Models
{
    public class AdminWiseUsers
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public string ApplicationUserId { get; set; }
        public ApplicationUser? ApplicationUser { get; set; }
        public ICollection<Reminder>? Reminders { get; set; }
    }
}
