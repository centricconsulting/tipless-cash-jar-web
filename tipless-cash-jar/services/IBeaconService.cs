using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiplessCashJar.entities;
using tiplessCashJar.repositories;
using tiplessCashJar.services.models;

namespace tiplessCashJar.services
{
    public interface IBeaconService
    {
        Task<List<BeaconServiceModel>> GetAllBeacons();
    }

    public class FakeBeaconService : IBeaconService
    {
        public async Task<List<BeaconServiceModel>> GetAllBeacons()
        {
            return new List<BeaconServiceModel> {
                new BeaconServiceModel { Name = "badge 1", Uuid = "DD915E3B-072C-4223-9A54-30839098679", Major = 57497, Minor = 25695},
                new BeaconServiceModel { Name = "badge 2", Uuid = "DD915E3B-072C-4223-9A54-308390986793", Major = 17356, Minor = 56347}
            };
        }
    }


    }