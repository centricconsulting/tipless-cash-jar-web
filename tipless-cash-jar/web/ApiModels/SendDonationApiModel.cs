using tiplessCashJar.entities;
using tiplessCashJar.services.models;

namespace tiplessCashJar.web.ApiModels
{
  public class SendDonationApiModel : ICanApplyTo<NewDonationServiceModel>
  {
    public string BeaconNumber { get; set; }
    public int Amount { get; set; }

    public NewDonationServiceModel ApplyTo(NewDonationServiceModel target)
    {
      target.BeaconNumber = BeaconNumber;
      target.Amount = Amount;

      return target;
    }
  }
}