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
  }

  public class FakeDonationService : IDonationService
  {
    public async Task<ExecutedDonationServiceModel> Execute(NewDonationServiceModel newDonation)
    {
      return new ExecutedDonationServiceModel { Id = Guid.NewGuid() };
    }
  }
}
