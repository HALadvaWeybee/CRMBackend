namespace CRMBackend.Data.Models
{
    public class ManageEvent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public long ContactCount { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; } = true;
        public int OrganizationORIndividualId { get; set; }
        public OrganizationORIndividual? OrganizationORIndividual { get; set; }
        public ICollection<ContactEvent>? ContactEvent { get; set; }
    }
}
