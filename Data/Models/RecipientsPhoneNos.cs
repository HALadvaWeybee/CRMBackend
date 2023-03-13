namespace CRMBackend.Data.Models
{
    public class RecipientsPhoneNos
    {
        public int Id { get; set; }
        public string? PhoneNo { get; set; }
        public int UserSMSId { get; set; }
        public UserSMS? UserSMS { get; set; }
    }
}
