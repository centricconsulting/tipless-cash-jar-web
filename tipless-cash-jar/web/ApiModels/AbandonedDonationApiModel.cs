using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Ninject.Syntax;
using tiplessCashJar.services.models;

namespace tiplessCashJar.web.ApiModels
{
  public class AbandonedDonationApiModel
  {
    public AbandonedDonationApiModel(DonationAbandonAckServiceModel ack)
    {
        WhenAbandoned = ack.WhenAbandoned;
    }

     public DateTime WhenAbandoned { get; private set; }
    }
}