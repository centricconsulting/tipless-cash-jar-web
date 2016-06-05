using System;
using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.repositories
{
  public interface IRefusalRepository
  {
    Task<RefusalEntity> Create(RefusalEntity entity);
    Task<RefusalEntity> GetRefusal(Guid id);
  }

  public class RefusalRepository : RepositoryBase, IRefusalRepository
  {
    public RefusalRepository(TiplessCashJarContext db) : base(db)
    {
    }

    public async Task<RefusalEntity> Create(RefusalEntity entity)
    {
      Db.Refusals.Add(entity);
      await Db.SaveChangesAsync();
      return entity;
    }

    public async Task<RefusalEntity> GetRefusal(Guid id)
    {
      var result = await Db.Refusals.FindAsync(id);
      return result;
    }
  }
}