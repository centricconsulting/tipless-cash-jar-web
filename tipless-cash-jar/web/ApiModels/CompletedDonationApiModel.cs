using System;
using tiplessCashJar.services;
using tiplessCashJar.services.models;

namespace tiplessCashJar.web.ApiModels
{
  public class CompletedDonationApiModel
  {

    public CompletedDonationApiModel(ExecutedDonationServiceModel donation)
    {
      Id = donation.Id;
    }

    public Guid Id { get; set; }
  }
}