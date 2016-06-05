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
    Task<DonationRefusalAckServiceModel> GetRefusal(Guid id);
    Task<DonationAbandonAckServiceModel> Abandon(string name);
    Task<DonationAbandonAckServiceModel> GetAbandonedDonations(Guid id);
  }
   
  public class DonationService : IDonationService
  {
    private IDonationRepository DonationRepository { get; set; }
    private IRecipientRepository RecipientRepository { get; set; }
    private IRefusalRepository RefusalRepository { get; set; }
    private IAbandonRepository AbandonRepository { get; set; }


    public DonationService(IDonationRepository donationRepository, IRecipientRepository recipRepo, IRefusalRepository refusalRepo, IAbandonRepository abandonRepository)
    {
      DonationRepository = donationRepository;
      RecipientRepository = recipRepo;
      RefusalRepository = refusalRepo;
      AbandonRepository = abandonRepository;
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

    public async Task<DonationRefusalAckServiceModel> GetRefusal(Guid id)
    {
      var result = await RefusalRepository.GetRefusal(id);
      return new DonationRefusalAckServiceModel(result);
    }

    public async Task<DonationAbandonAckServiceModel> Abandon(String name)
    {
      var recipient = await RecipientRepository.GetByBeaconName(name);
      if (recipient == null) return null;

      var abandon = new AbandonEntity
      {
        GiverId = Guid.NewGuid(),
        RecipientId = recipient.Id,
        BeaconName = recipient.BeaconName
      };

      var result = await AbandonRepository.Create(abandon);
      return new DonationAbandonAckServiceModel(result);
    }

    public async Task<DonationAbandonAckServiceModel> GetAbandonedDonations(Guid id)
    {
      var result = await AbandonRepository.GetAbandonedDonations(id);
      return new DonationAbandonAckServiceModel(result);
    }
  }
}
