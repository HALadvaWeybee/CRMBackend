using CRMBackend.Models;

namespace CRMBackend.Data.Models
{
    public class UserSMS
    {
        public int Id { get; set; }
        //public int AdminWiseUsersId { get; set; }
        //public string ApplicationUserId { get; set; }
        //public ApplicationUser? ApplicationUser { get; set; }
        public int OrganizationORIndividualId { get; set; }
        public OrganizationORIndividual? OrganizationORIndividual { get; set; }
        public string? Message { get; set; }
        public ICollection<RecipientsPhoneNos>? Recipients { get; set; }
    }
}
