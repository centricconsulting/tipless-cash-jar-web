using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.services.models
{
  public class DonationRefusalAckServiceModel
  {
    public DonationRefusalAckServiceModel(RefusalEntity result)
    {
      Id = result.Id;
      Name = result.BeaconName;
      WhenRefused = result.WhenCreated;
    }

    public DateTime WhenRefused { get; set; }

    public string Name { get; set; }

    public Guid Id { get; set; }
  }
}
