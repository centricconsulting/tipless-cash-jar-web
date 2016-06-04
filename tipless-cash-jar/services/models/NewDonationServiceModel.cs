using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.services.models
{
  public class NewDonationServiceModel : ICanApplyTo<DonationEntity>
  {
    public Guid GiverId { get; set; }
    public string BeaconNumber { get; set; }
    public int Amount { get; set; }

    public DonationEntity ApplyTo(DonationEntity target)
    {
      target.BeaconNumber = BeaconNumber;
      target.Amount = Amount;
      target.GiverId = GiverId;

      return target;
    }
  }
}
