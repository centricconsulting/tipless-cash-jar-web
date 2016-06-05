using System;
using tiplessCashJar.entities;

namespace tiplessCashJar.services.models
{
  public class TransactionServiceModel
  {
    public TransactionServiceModel(DonationEntity donation)
    {
      Id = donation.Id;
      When = donation.WhenCreated;
      Amount = donation.Amount;
      RecipientId = donation.BeaconNumber;
    }

    public string RecipientId { get; set; }

    public int Amount { get; set; }

    public DateTime When { get; set; }

    public Guid Id { get; set; }
  }
}