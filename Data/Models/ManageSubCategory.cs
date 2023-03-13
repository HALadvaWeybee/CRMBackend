namespace CRMBackend.Data.Models
{
    public class ManageSubCategory
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int CategoryId { get; set; }
        public ManageCategory? Category { get; set; }
    }
}
