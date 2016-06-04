using System;
using tiplessCashJar.services;
using tiplessCashJar.services.models;

namespace tiplessCashJar.web.ApiModels
{
    public class BeaconApiModel
    {
        public BeaconApiModel(BeaconServiceModel beacon)
        {
            Name = beacon.Name;
            Uuid = beacon.Uuid;
            Major = beacon.Major;
            Minor = beacon.Minor;
        }

        public int Major { get; private set; }
        public int Minor { get; private set; }
        public string Name { get; private set; }
        public string Uuid { get; private set; }
    }
}