using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using fhj_est_customer_portal.Entities;

namespace fhj_est_customer_portal.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ChargingStation> ChargingStations { get; set; } = null!;  
        public DbSet<Books> Books { get; set; } = null!;
    }
}
