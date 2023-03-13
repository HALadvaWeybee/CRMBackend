using CRMBackend.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CRMBackend.Data.Models
{
    public class RMbackendContext : IdentityDbContext<ApplicationUser>
    {
        public RMbackendContext(DbContextOptions<RMbackendContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<States>().HasMany(x => x.Cities).WithOne(x => x.States).OnDelete(DeleteBehavior.NoAction);

            //configure many to many relationship between Contact and ManageEvent
            /*modelBuilder.Entity<ContactEvent>().HasOne(x => x.ManageEvent).WithMany(y => y.ContactEvent).HasForeignKey(z => z.ManageEventId);
            modelBuilder.Entity<ContactEvent>().HasOne(x => x.Contact).WithMany(y => y.ContactEvent).HasForeignKey(z => z.ContactId);*/

            //modelBuilder.Entity<ManageEvent>()
            //        .HasMany(t => t.Con)
            //        .WithMany(t => t.ManageEvents)
            //        .UsingEntity(j => j.ToTable("ContactEvent"));

            modelBuilder.Entity<ContactEvent>().HasKey(t => new { t.ContactsId, t.ManageEventsId });


            modelBuilder.Entity<ContactEvent>()
                        .HasOne(t => t.Contacts)
                        .WithMany(t => t.ContactEvent)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ContactEvent>()
                        .HasOne(t => t.ManageEvents)
                        .WithMany(t => t.ContactEvent)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<ContactEvent>().HasOne(x => x.Contacts).WithMany(x => x.ContactEvent).OnDelete(DeleteBehavior.NoAction);



            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Reminder> Reminders { get; set; }
        public DbSet<OrganizationORIndividual> OrganizationORIndividual { get; set; }
        public DbSet<UserSMS> UserSMSs { get; set; }
        public DbSet<RecipientsPhoneNos> RecipientsPhoneNos { get; set; }
        public DbSet<UserEmail> UserEmails { get; set; }
        public DbSet<RecipientsEmails> RecipientsEmails { get; set; }
        public DbSet<ManageGroup> ManageGroup { get; set; }
        public DbSet<ManageCategory> ManageCategory { get; set; }
        public DbSet<ManageSubCategory> ManageSubCategory { get; set; }
        public DbSet<ManageEvent> ManageEvent { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<ContactEvent> ContactEvent { get; set; }
        public DbSet<UserPhoto> UserPhoto { get; set; }
        public DbSet<UserNote> UserNote { get; set; }
        public DbSet<UserDocument> UserDocument { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<City> Cities { get; set; }

    }
}
