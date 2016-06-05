using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tiplessCashJar.entities;

namespace tiplessCashJar.services.models
{
    public class DonationAbandonAckServiceModel
    {
        public DonationAbandonAckServiceModel(AbandonEntity result)
        {
            Id = result.Id;
            Name = result.BeaconName;
            WhenAbandoned = result.WhenCreated;
        }

        public string Name { get; set; }

        public Guid Id { get; set; }

        public DateTime WhenAbandoned { get; set; }
    }
}
