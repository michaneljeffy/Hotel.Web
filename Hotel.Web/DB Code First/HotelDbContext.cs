using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Hotel.Web.DB;
using Hotel.Web.DB_Code_First;
using Hotel.Web.Models;

namespace Hotel.Web.DB
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext():base("localhost")
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<UserData> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<HotelDbContext>());
            base.OnModelCreating(modelBuilder);
        }

      

    }
}