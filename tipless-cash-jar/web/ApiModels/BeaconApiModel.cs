using System;
using tiplessCashJar.services;
using tiplessCashJar.services.models;

namespace tiplessCashJar.web.ApiModels
{
    public class BeaconApiModel
    {
        public BeaconApiModel(BeaconServiceModel beacon)
        {
            Id = beacon.Id;
        }

        public Guid Id { get; private set; }
    }
}