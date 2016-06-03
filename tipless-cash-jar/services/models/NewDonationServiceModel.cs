using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiplessCashJar.services.models
{
  public class NewDonationServiceModel
  {
    public Guid GiverId { get; set; }
    public string BeaconNumber { get; set; }
    public int Amount { get; set; }
  }

  public class ExecutedDonationServiceModel
  {
    public Guid Id { get; set; }
  }
}
