using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using J2.Models;

namespace J2.Data
{
    public class VendorContext : DbContext
    {
        public VendorContext (DbContextOptions<VendorContext> options)
            : base(options)
        {
        }

        public DbSet<J2.Models.Vendor> Vendor { get; set; }
        
        public DbSet<J2.Models.Link> Link { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Vendor>().ToTable("Vendor");
        //     modelBuilder.Entity<Link>().ToTable("Link");
        // }
    }
}
