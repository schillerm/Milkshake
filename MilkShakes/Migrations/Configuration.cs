namespace MilkShakes.Migrations
{
    using System;
    using System.Data.Entity;
    using MilkShakes.Models.Entities;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MilkShakes.Models.Entities.MilkshakeDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MilkShakes.Models.Entities.MilkshakeDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Milks.AddOrUpdate(
              p => p.Name,
              new Milk { Name = "Semi Skimmed" },
              new Milk { Name = "Skimmed" },
              new Milk { Name = "Soya milk" }
            );

            //

            context.Fruits.AddOrUpdate(
             p => p.Name,
             new Fruit { Name = "Orange" },
             new Fruit { Name = "Banana" },
             new Fruit { Name = "Lemon" }
           );

            //
        }
    }
}
