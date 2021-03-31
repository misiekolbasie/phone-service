using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PhoneService.DataAccess.Entities;
using PhoneService.Models;

namespace PhoneService.DataAccess
{
    public class PhoneContext : DbContext
    {
        public PhoneContext(DbContextOptions<PhoneContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PhoneEntity>().HasKey(u => u.Model);
             //modelBuilder.Entity<PhoneEntity>().HasKey(p => p.Price);
            //modelBuilder.Entity<PhoneEntity>().Property(p => p.Price).HasPrecision(15, 2);
        }

        public DbSet<PhoneEntity> Phones { get; set; }
    }
}
