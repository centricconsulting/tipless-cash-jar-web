using tiplessCashJar.entities;

namespace tiplessCashJar.repositories.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<tiplessCashJar.repositories.TiplessCashJarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(tiplessCashJar.repositories.TiplessCashJarContext context)
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
      context.Beacons.AddOrUpdate(
         p => p.Name,
         new BeaconEntity { Id = Guid.NewGuid(), Name = "badge 1", UUID = "DD915E3B-072C-4223-9A54-308390986793", Major = "57497", Minor = "25695", WhenCreated = DateTime.UtcNow },
         new BeaconEntity { Id = Guid.NewGuid(), Name = "badge 2", UUID = "DD915E3B-072C-4223-9A54-308390986793", Major = "17356", Minor = "56347", WhenCreated = DateTime.UtcNow }
       );
    }


    }
}
