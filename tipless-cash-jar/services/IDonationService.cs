using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiplessCashJar.services.models;

namespace tiplessCashJar.services
{
    public interface IDonationService
    {
        Task<ExecutedDonationServiceModel> Execute(NewDonationServiceModel newDonation);
        Task<ExecutedDonationServiceModel> GetById(Guid id);
    }

    public class DonationService : IDonationService
    {
        public Task<ExecutedDonationServiceModel> Execute(NewDonationServiceModel newDonation)
        {
            throw new NotImplementedException();
        }

        public Task<ExecutedDonationServiceModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeDonationService : IDonationService
    {
        public async Task<ExecutedDonationServiceModel> Execute(NewDonationServiceModel newDonation)
        {
            return new ExecutedDonationServiceModel { Id = Guid.NewGuid() };
        }

        public async Task<ExecutedDonationServiceModel> GetById(Guid id)
        {
            return new ExecutedDonationServiceModel { Id = id };
        }
    }
}
