using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Routing;
using tiplessCashJar.services;
using tiplessCashJar.web.ApiModels;
using tiplessCashJar.web.Core;

namespace tiplessCashJar.web.Api
{
  public class AbandonController : AppApiControllerBase
  {
    private IDonationService DonationService { get; set; }

    public AbandonController(IDonationService donationService) { DonationService = donationService; }

    [HttpPost]
    [Route("api/abandoned/{name}")]
    public async Task<IHttpActionResult> AbandonDonation(string name)
    {
      var response = await DonationService.Abandon(name);

      if (response == null) return NotFound();

      return CreatedAtRoute("DefaultApi", new { controller = "Abandon", id = response.Id }, new AbandonedDonationApiModel(response));
    }

    [HttpGet]
    [Route("api/abandoned/{id:Guid}")]
    [ResponseType(typeof(AbandonedDonationApiModel))]
    public async Task<IHttpActionResult> GetAbandon(Guid id)
    {
      var response = await DonationService.GetAbandonedDonations(id);
      if (response == null) return NotFound();

      return Ok(new AbandonedDonationApiModel(response));
    }
  }
}
