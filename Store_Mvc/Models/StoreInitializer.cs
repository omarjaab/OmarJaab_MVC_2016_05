using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Store_Mvc.Models
{
    public class StoreInitializer:DropCreateDatabaseAlways<StoreDbContext>
    {
        //omarjaab
        protected override void Seed(StoreDbContext context)
        {
           var stores=new List<Store>()
           {
               new Store()
               {
                   Id = 1,
                   Name = "Coop",
                   Address = "välaCentrum"
               },
               new Store()
               {
                   Id = 2,
                   Name = "Willys",
                   Address = "Rosengård"
               },
           };
            foreach (var store in stores)
            {
                context.Stores.Add(store);
            }
            context.SaveChanges();

            var products=new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "twix",
                    Price = 9.99,
                    ProductInStock = "yes",
                    ProductNumber = "p-111",
                    ProductText = "describtion for product",
                },
                new Product()
                {
                    Id = 1,
                    Name = "mars",
                    Price = 9.99,
                    ProductInStock = "yes",
                    ProductNumber = "p-1121",
                    ProductText = "describtion for product",
                },
                new Product()
                {
                    Id = 2,
                    Name = "chips",
                    Price = 9.99,
                    ProductInStock = "yes",
                    ProductNumber = "p-155",
                    ProductText = "describtion for product",
                },
                new Product()
                {
                    Id = 2,
                    Name = "hot chili",
                    Price = 9.99,
                    ProductInStock = "yes",
                    ProductNumber = "p-12",
                    ProductText = "describtion for product",
                }
            };
            foreach (var product in products)
            {
                context.Products.Add(product);
            }
            context.SaveChanges();
        }
    }
}