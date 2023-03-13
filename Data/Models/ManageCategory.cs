namespace CRMBackend.Data.Models
{
    public class ManageCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int GroupId { get; set; }
        public ManageGroup? Group { get; set; }
        public ICollection<ManageSubCategory>? SubCategories { get; set; }
    }
}
