namespace CRMBackend.Data.Models
{
    public class ContactEvent
    {
        public int ContactsId { get; set; }
        public Contacts Contacts { get; set; }
        public int ManageEventsId { get; set; }
        public ManageEvent ManageEvents { get; set; }

    }
}
