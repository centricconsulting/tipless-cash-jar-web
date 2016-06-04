using System;

namespace tiplessCashJar.entities
{
  public class BeaconEntity : EntityBase<Guid>
  {
    public BeaconEntity()
    {
      Id = Guid.NewGuid();
    }

    public string Name { get; set; }
    public string UUID { get; set; }
    public string Major { get; set; }
    public string Minor { get; set; }
  }
}