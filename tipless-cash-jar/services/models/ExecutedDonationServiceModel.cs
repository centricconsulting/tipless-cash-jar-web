using System;
using tiplessCashJar.entities;

namespace tiplessCashJar.services.models
{
    public class ExecutedDonationServiceModel
    {
        public ExecutedDonationServiceModel()
        {
        }

        public ExecutedDonationServiceModel(DonationEntity result)
        {
            Id = result.Id;
            Amount = result.Amount;
            BeaconNumber = result.BeaconNumber;
            GiverId = result.GiverId;
            WhenGiven = result.WhenCreated;
        }

        public int Amount { get; private set; }
        public string BeaconNumber { get; private set; }
        public Guid GiverId { get; private set; }
        public Guid Id { get; set; }
        public DateTime WhenGiven { get; private set; }
    }
}