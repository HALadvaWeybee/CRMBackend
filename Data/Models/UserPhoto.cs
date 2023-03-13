namespace CRMBackend.Data.Models
{
    public class UserPhoto
    {
        public int Id { get; set; }
        public string? ImageUrl { get; set; }
        public int ContactsId { get; set; }
        public Contacts? Contacts { get; set; }
    }
    public class UserNote
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public int ContactsId { get; set; }
        public Contacts? Contacts { get; set; }
    }
    public class UserDocument
    {
        public int Id { get; set; }
        public string? DocumentUrl { get; set; }
        public int ContactsId { get; set; }
        public Contacts? Contacts { get; set; }
    }
}
