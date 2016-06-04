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
  public interface IDonationService
  {
    Task<ExecutedDonationServiceModel> Create(NewDonationServiceModel newDonation);
    Task<ExecutedDonationServiceModel> GetById(Guid id);
  }

  public class DonationService : IDonationService
  {
    private IDonationRepository DonationRepository { get; set; }

    public DonationService(IDonationRepository donationRepository)
    {
      DonationRepository = donationRepository;
    }

    public async Task<ExecutedDonationServiceModel> Create(NewDonationServiceModel newDonation)
    {
      var newEntity = new DonationEntity();
      newEntity = newDonation.ApplyTo(newEntity);
      var result = await DonationRepository.Create(newEntity);
      return new ExecutedDonationServiceModel(result);
    }

    public async Task<ExecutedDonationServiceModel> GetById(Guid id)
    {
      var result = await DonationRepository.GetById(id);
      return new ExecutedDonationServiceModel(result);
    }
  }
}
