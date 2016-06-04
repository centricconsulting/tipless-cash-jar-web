using System;

namespace tiplessCashJar.entities
{
  public class RefusalEntity : EntityBase<Guid>
  {
    public RefusalEntity()
    {
      Id = Guid.NewGuid();
    }

    public Guid GiverId { get; set; }
    public Guid RecipientId { get; set; }
    public string BeaconName { get; set; }
  }
}