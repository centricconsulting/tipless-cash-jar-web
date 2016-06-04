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

    public class BeaconService : IBeaconService
    {
        private IBeaconRepository BeaconRepository { get; set; }

        public BeaconService(IBeaconRepository beaconRepository)
        {
            BeaconRepository = beaconRepository;
        }

        public async Task<List<BeaconServiceModel>> GetAllBeacons()
        {
            var results = await BeaconRepository.GetAllBeacons();

            var response = new List<BeaconServiceModel>();
            foreach (var result in results)
            {
                response.Add(new BeaconServiceModel(result));
            }

            return response;
        }
    }

}