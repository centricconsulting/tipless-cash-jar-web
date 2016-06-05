using System;
using System.Threading.Tasks;
using System.Web.Mvc;
using tiplessCashJar.services;
using tiplessCashJar.web.Core;

namespace tiplessCashJar.web.Controllers
{
  public class RecipientController : AppControllerBase
  {
    //private IRecipientService RecipientService { get; set; }

    //public RecipientController(IRecipientService recipientService) { RecipientService = recipientService; }

    [HttpGet]
    [Route("recipient/profile/{id:Guid}")]
    public async Task<ActionResult> GetRecipientProfile(Guid id)
    {
      return View("Profile");
    }

  }
}