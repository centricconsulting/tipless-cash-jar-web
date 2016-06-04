using System;

namespace tiplessCashJar.entities
{
    public class BeaconEntity : EntityBase<Guid>
    {
        private BeaconEntity result;

        public BeaconEntity()
        {
            Id = Guid.NewGuid();
        }

        public BeaconEntity(BeaconEntity result)
        {
            this.result = result;
        }

        public string Name { get; set; }
        public string UUID { get; set; }
        public string Major { get; set; }
        public string Minor { get; set; }
    }
}