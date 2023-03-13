using CRMBackend.Models;

namespace CRMBackend.Data.Models
{
    public class ManageGroup
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //public string ApplicationUserId { get; set; }
        //public ApplicationUser? ApplicationUser { get; set; }
        public int OrganizationORIndividualId { get; set; }
        public OrganizationORIndividual? OrganizationORIndividual { get; set; }
        public ICollection<ManageCategory>? Categories { get; set; }
    }
}
