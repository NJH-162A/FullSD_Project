using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FullSD_Proj_new.Domain;

namespace FullSD_Proj_new.Data
{
    public class FullSD_Proj_newContext : DbContext
    {
        public FullSD_Proj_newContext (DbContextOptions<FullSD_Proj_newContext> options)
            : base(options)
        {
        }

        public DbSet<FullSD_Proj_new.Domain.Accomodation> Accomodation { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.Location> Location { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.Transport> Transport { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.TripDetail> TripDetail { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.TripDetailsType> TripDetailsType { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.Trip> Trip { get; set; } = default!;
        public DbSet<FullSD_Proj_new.Domain.User> User { get; set; } = default!;
    }
}
