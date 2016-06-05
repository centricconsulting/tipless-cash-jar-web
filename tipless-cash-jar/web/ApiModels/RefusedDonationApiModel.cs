using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using tiplessCashJar.services.models;

namespace tiplessCashJar.web.ApiModels
{
  public class RefusedDonationApiModel
  {
    public RefusedDonationApiModel(DonationRefusalAckServiceModel ack)
    {
      WhenRefused = ack.WhenRefused;
    }

    public DateTime WhenRefused { get; private set; }
  }
}