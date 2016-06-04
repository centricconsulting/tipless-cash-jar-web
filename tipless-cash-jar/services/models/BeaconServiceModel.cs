using System;
using tiplessCashJar.entities;

namespace tiplessCashJar.services.models
{
    public class BeaconServiceModel
    {
  
        public BeaconServiceModel(BeaconEntity beacon)
        {
            Major = beacon.Major;
            Minor = beacon.Minor;
            Name = beacon.Name;
            Uuid = beacon.UUID;

        }

        public string Major { get; internal set; }
        public string Minor { get; internal set; }
        public string Name { get; internal set; }
        public string Uuid { get; internal set; }
    }

}