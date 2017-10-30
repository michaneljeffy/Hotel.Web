using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Hotel.Web.DB;

namespace Hotel.Web.DB
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext():base("localhost")
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<HotelDbContext>());
            base.OnModelCreating(modelBuilder);
        }

      

    }
}