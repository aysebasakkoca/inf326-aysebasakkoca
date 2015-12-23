namespace DamacanaStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DamacanaStore.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<DamacanaStore.Models.DamacanaStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DamacanaStore.Models.DamacanaStoreContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

         

            context.Products.AddOrUpdate(x => x.Id,
                new Product()
                {
                    Id = 1,
                    Name = "Erikli",
                    Price = 9 ,
                },
                new Product()
                {
                    Id = 2,
                    Name = "Nestle",
                    Price = 8,
                   
                },
                new Product()
                {
                    Id = 3,
                    Name = "Sýrma",
                    Price = 7,
                 
                },
                new Product()
                {
                    Id = 4,
                    Name = "Don Quixote",
                    Price = 1617,
                    
                }
                );
        }
    }
}
