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
    Task<DonationRefusalAckServiceModel> Refuse(string name);
  }
   
  public class DonationService : IDonationService
  {
    private IDonationRepository DonationRepository { get; set; }
    private IRecipientRepository RecipientRepository { get; set; }
    private IRefusalRepository RefusalRepository { get; set; }


    public DonationService(IDonationRepository donationRepository, IRecipientRepository recipRepo, IRefusalRepository refusalRepo)
    {
      DonationRepository = donationRepository;
      RecipientRepository = recipRepo;
      RefusalRepository = refusalRepo;
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

    public async Task<DonationRefusalAckServiceModel> Refuse(string name)
    {
      var recipient = await RecipientRepository.GetByBeaconName(name);
      if (recipient == null) return null;

      var refusal = new RefusalEntity
      {
        GiverId = Guid.NewGuid(),
        RecipientId = recipient.Id,
        BeaconName = recipient.BeaconName
      };

      var result = await RefusalRepository.Create(refusal);

      return new DonationRefusalAckServiceModel(result);
    }
  }
}
