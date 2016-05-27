using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Store_Mvc.Models
{
    public class StoreDbContext:DbContext
    {
        //omarJaab
        public StoreDbContext() : base("StoreEntity")
        {
            Database.SetInitializer<StoreDbContext>(new StoreInitializer());
        }

        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }

    }
}