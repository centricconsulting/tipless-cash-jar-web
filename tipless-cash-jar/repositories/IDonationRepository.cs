using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.repositories
{
  public interface IDonationRepository
  {
    Task<DonationEntity> Create(DonationEntity entity);
    Task<DonationEntity> GetById(Guid id);
    Task<List<DonationEntity>> GetAll();
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

    public async Task<List<DonationEntity>> GetAll()
    {
      return await Db.Donations.ToListAsync();
    }

    public DonationRepository(TiplessCashJarContext db) : base(db)
    {
    }
  }
}