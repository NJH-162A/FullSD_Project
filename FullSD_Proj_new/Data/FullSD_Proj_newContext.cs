using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FullSD_Proj_new.Data;

namespace FullSD_Proj_new.Data
{
    public class FullSD_Proj_newContext(DbContextOptions<FullSD_Proj_newContext> options) : IdentityDbContext<FullSD_Proj_newUser>(options)
    {
        public DbSet<FullSD_Proj_new.Domain.Accomodation> Accomodation { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.Location> Location { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.Transport> Transport { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.TripDetail> TripDetail { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.TripDetailsType> TripDetailsType { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.Trip> Trip { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.User> User { get; set; } = default!;
    }

}
