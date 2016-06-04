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
                new BeaconServiceModel { Id = Guid.NewGuid() },
                new BeaconServiceModel { Id = Guid.NewGuid() }
            };
        }
    }


    }