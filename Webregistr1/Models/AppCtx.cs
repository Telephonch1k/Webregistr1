using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Webregistr1.Models
{
    public class AppCtx : IdentityDbContext<User>
    {
        public AppCtx(DbContextOptions<AppCtx> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<FormOfStudy> FormsOfStudy { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
    }
}