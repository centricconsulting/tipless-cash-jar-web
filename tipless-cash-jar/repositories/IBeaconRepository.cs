using System.Threading.Tasks;
using System.Collections.Generic;
using tiplessCashJar.entities;
using System.Data.Entity;

namespace tiplessCashJar.repositories
{
    public interface IBeaconRepository
    {
        Task<List<BeaconEntity>> GetAllBeacons();
    }

    public class BeaconRepository : RepositoryBase, IBeaconRepository
    {
        public BeaconRepository(TiplessCashJarContext db) : base(db)
        {
        }

        public async Task<List<BeaconEntity>> GetAllBeacons()
        {
            var results = await Db.Beacons.ToListAsync();

            return results;
        }
    }

}