using CRMBackend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CRMBackend.Data.Models
{
    public class CRMbackendContext : IdentityDbContext<ApplicationUser>
    {
        public CRMbackendContext(DbContextOptions<CRMbackendContext> options) : base(options)
        {

        }


    }
}
