using System;

namespace tiplessCashJar.entities
{
  public class DonationEntity : EntityBase<Guid>
  {
    public string BeaconNumber { get; set; }
    public int Amount { get; set; }
    public Guid GiverId { get; set; }

    public DonationEntity()
    {
      Id = Guid.NewGuid();
    }
  }
}