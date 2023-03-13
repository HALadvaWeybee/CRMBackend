using CRMBackend.Models;

namespace CRMBackend.Data.Models
{
    public class OrganizationORIndividual
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        //public ICollection<ManageGroup>? ManageGroups { get; set; }
        //public ICollection<ManageEvent>? ManageEvents { get; set; }
        //public ICollection<UserSMS>? UserSMS { get; set; }
        //public ICollection<UserEmail>? UserEmail { get; set; }
        //public ICollection<Contacts>? Contacts { get; set; }
        //public ICollection<Reminder>? Reminder { get; set; }
        //public ICollection<ApplicationUser>? ApplicationUsers { get; set; }
    }
}
