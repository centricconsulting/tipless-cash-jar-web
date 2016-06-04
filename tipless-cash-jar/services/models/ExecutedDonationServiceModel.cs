using System;
using tiplessCashJar.entities;

namespace tiplessCashJar.services.models
{
  public class ExecutedDonationServiceModel
  {
    public ExecutedDonationServiceModel()
    {
    }

    public ExecutedDonationServiceModel(DonationEntity result)
    {
      Id = result.Id;
    }

    public Guid Id { get; set; }
  }
}