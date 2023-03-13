using CRMBackend.Models;

namespace CRMBackend.Data.Models
{
    public class UserEmail
    {
        public int Id { get; set; }
        //public int AdminWiseUsersId { get; set; }
        //public AdminWiseUsers? AdminWiseUsers { get; set; }
        //public string ApplicationUserId { get; set; }
        //public ApplicationUser? ApplicationUser { get; set; }
        public int OrganizationORIndividualId { get; set; }
        public OrganizationORIndividual? OrganizationORIndividual { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
        public ICollection<RecipientsEmails>? Recipients { get; set; }
    }
}
