using System.Collections.Generic;
using System.Threading.Tasks;
using tiplessCashJar.repositories;
using tiplessCashJar.services.models;

namespace tiplessCashJar.services
{
  public interface IAccountService
  {
    Task<List<TransactionServiceModel>>  GetAllMyTransactions();
  }

  public class AccountService : IAccountService
  {
    private IDonationRepository DonationRepository { get; set; }

    public AccountService(IDonationRepository donationRepository)
    {
      DonationRepository = donationRepository;
    }
    public async Task<List<TransactionServiceModel>> GetAllMyTransactions()
    {
      var entities = await DonationRepository.GetAll();
      var response = new List<TransactionServiceModel>();
      foreach (var donation in entities)
      {
        response.Add(new TransactionServiceModel(donation));
      }

      return response;
    }
  }
}