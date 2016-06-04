using System;
using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.repositories
{
  public class RecipientRepository : RepositoryBase, IRecipientRepository
  {
    public RecipientRepository(TiplessCashJarContext db) : base(db)
    {
    }

    public async Task<RecipientEntity> GetByBeaconName(string name)
    {
      return new RecipientEntity
      {
        BeaconName = name
      };
    }
  }
}