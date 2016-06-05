using System;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using tiplessCashJar.services;
using tiplessCashJar.web.ApiModels;
using tiplessCashJar.web.Core;

namespace tiplessCashJar.web.Api
{
  public class RefusalController : AppApiControllerBase
  {
    private IDonationService DonationService { get; set; }

    public RefusalController(IDonationService donationService) { DonationService = donationService; }

    [HttpPost]
    [Route("api/refuse/{name}")]
    public async Task<IHttpActionResult> RefuseDonation(string name)
    {
      var response = await DonationService.Refuse(name);

      if (response == null) return NotFound();

      return CreatedAtRoute("DefaultApi", new { controller = "Refusal", id = response.Id }, new RefusedDonationApiModel(response));
    }

    [HttpGet]
    [Route("api/refusal/{id:Guid}")]
    [ResponseType(typeof(RefusedDonationApiModel))]
    public async Task<IHttpActionResult> GetRefusal(Guid id)
    {
        var response = await DonationService.GetRefusal(id);
        if (response == null) return NotFound();

        return Ok(new RefusedDonationApiModel(response));
    }
  }
}