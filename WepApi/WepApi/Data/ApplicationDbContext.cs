using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WepApi.Models;

namespace WepApi.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //public ApplicationDbContext(DbContextOptions options)
        //    : base(options)
        //{

        //}



        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<Country>().HasMany(x => x.States).WithOne(x => x.Country).HasForeignKey(x => x.CountryId);
            builder.Entity<State>().HasMany(x => x.Contacts).WithOne(x => x.State).HasForeignKey(x => x.StateId);
            builder.Entity<Country>().HasMany(x => x.Contacts).WithOne(x => x.Country).HasForeignKey(x => x.CountryId);
            //  builder.Entity<Country>().HasMany(x => x.Contacts).WithRequired(x => x.Country).HasForeignKey(x => x.CountryId).WillCascadeOnDelete();

         

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=220.158.164.95,10000;Database=KBI140717;Trusted_Connection=false;user id=Fluser1;password=Kbi@123456;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer(@"Data Source=Sachin;Initial Catalog=AngularApp;Integrated Security=true");
        }
    }
}
