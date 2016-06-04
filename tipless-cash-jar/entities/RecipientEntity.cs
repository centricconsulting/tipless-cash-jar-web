using System;

namespace tiplessCashJar.entities
{
  public class RecipientEntity : EntityBase<Guid>
  {
    public RecipientEntity()
    {
      Id = Guid.NewGuid();
    }

    public string BeaconName { get; set; }
  }
}