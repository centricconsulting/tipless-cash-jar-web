using System;
using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.repositories
{
  public interface IDonationRepository
  {
    Task<DonationEntity> Create(DonationEntity entity);
    Task<DonationEntity> GetById(Guid id);
  }

  public class DonationRepository : RepositoryBase, IDonationRepository
  {
    public async Task<DonationEntity> Create(DonationEntity entity)
    {
      Db.Donations.Add(entity);
      await Db.SaveChangesAsync();
      return entity;
    }

    public async Task<DonationEntity> GetById(Guid id)
    {
      var result = await Db.Donations.FindAsync(id);
      return result;
    }

    public DonationRepository(TiplessCashJarContext db) : base(db)
    {
    }
  }

  public abstract class RepositoryBase
  {
    protected TiplessCashJarContext Db { get; set; }

    protected RepositoryBase(TiplessCashJarContext db)
    {
      Db = db;
    }
  }
}