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
              new BeaconEntity { Id = Guid.NewGuid(), Name = "abc123", UUID = "???", Major = "0", Minor = "4", WhenCreated = DateTime.UtcNow }
            );
        }
    }
}
