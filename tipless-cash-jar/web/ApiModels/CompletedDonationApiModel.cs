using System;
using tiplessCashJar.services;
using tiplessCashJar.services.models;

namespace tiplessCashJar.web.ApiModels
{
  public class CompletedDonationApiModel
  {

    public CompletedDonationApiModel(ExecutedDonationServiceModel donation)
    {
      Id = donation.Id;
            Amount = donation.Amount;
            WhenGiven = donation.WhenGiven;
            GiverId = donation.GiverId;
            BeaconNumber = donation.BeaconNumber;
    }

        public int Amount { get; private set; }
        public string BeaconNumber { get; private set; }
        public Guid GiverId { get; private set; }
        public Guid Id { get; set; }
        public DateTime WhenGiven { get; private set; }
    }
}