using System;
using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.repositories
{
  public interface IAbandonRepository
  {
    Task<AbandonEntity> Create(AbandonEntity entity);
    Task<AbandonEntity> GetAbandonedDonations(Guid id);
  }

  public class AbandonRepository : RepositoryBase, IAbandonRepository
  {
    public AbandonRepository(TiplessCashJarContext db) : base(db)
    {
    }

    public async Task<AbandonEntity> Create(AbandonEntity entity)
    {
      Db.Abandons.Add(entity);
      await Db.SaveChangesAsync();
      return entity;
    }

    public async Task<AbandonEntity> GetAbandonedDonations(Guid id)
    {
      var result = await Db.Abandons.FindAsync(id);
      return result;
    }
  }
}