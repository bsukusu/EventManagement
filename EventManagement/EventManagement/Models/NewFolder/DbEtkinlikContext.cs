using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace EventManagement.Models.NewFolder
{
    public partial class DbEtkinlikContext : DbContext
    {
        public DbEtkinlikContext()
        {
        }

        public DbEtkinlikContext(DbContextOptions<DbEtkinlikContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Event> Events { get; set; } = null!;
        public virtual DbSet<Participants> Participants { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=EventManagement;Trusted_Connection=True;");
            }
        }

    }
}
