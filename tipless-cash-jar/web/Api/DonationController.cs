using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using tiplessCashJar.services;
using tiplessCashJar.services.models;
using tiplessCashJar.web.ApiModels;

namespace tiplessCashJar.web.Api
{
  public class DonationController : ApiController
  {
    private IDonationService DonationService { get; set; }

    public DonationController(IDonationService donationService) { DonationService = donationService; }

    [HttpPost]
    [Route("api/donate")]
    public async Task<IHttpActionResult> Donate([FromBody] SendDonationApiModel donation)
    {
      if (!ModelState.IsValid) return BadRequest("Donation model is invalid.");

      var newDonation = new NewDonationServiceModel { GiverId = Guid.NewGuid() };
      newDonation = donation.ApplyTo(newDonation);

      try
      {
        var finalizedDonation = await DonationService.Execute(newDonation);
        return CreatedAtRoute("DefaultApi", new { controller = "Donation", id = finalizedDonation.Id }, new CompletedDonationApiModel(finalizedDonation));
      }
      catch (Exception e)
      {
        return InternalServerError(e);
      }
    }
  }
}
