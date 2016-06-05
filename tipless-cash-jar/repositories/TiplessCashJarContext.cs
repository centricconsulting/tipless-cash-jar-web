using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.repositories
{
  public class TiplessCashJarContext : DbContext
  {
    public DbSet<DonationEntity> Donations { get; set; }
    public DbSet<RefusalEntity> Refusals { get; set; }
    public DbSet<BeaconEntity> Beacons { get; set; }
    public DbSet<AbandonEntity> Abandons { get; set; }

    public TiplessCashJarContext() : base("tipless-cash-jar-connection-string")
    {
    }
  }
}
