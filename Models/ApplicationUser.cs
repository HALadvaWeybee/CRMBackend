using Microsoft.AspNetCore.Identity;

namespace CRMBackend.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
