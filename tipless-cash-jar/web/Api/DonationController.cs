﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using tiplessCashJar.services;
using tiplessCashJar.services.models;
using tiplessCashJar.web.ApiModels;
using tiplessCashJar.web.Core;
using WebGrease;

namespace tiplessCashJar.web.Api
{
  public class DonationController : AppApiControllerBase
  {
    private IDonationService DonationService { get; set; }
    private IAccountService AccountService { get; set; }

    public DonationController(IDonationService donationService, IAccountService accountService)
    {
      DonationService = donationService;
      AccountService = accountService;
    }

    [HttpPost]
    [Route("api/donate")]
    public async Task<IHttpActionResult> Donate([FromBody] SendDonationApiModel donation)
    {
      if (!ModelState.IsValid) return BadRequest("Donation model is invalid.");

      var newDonation = new NewDonationServiceModel { GiverId = Guid.NewGuid() };
      newDonation = donation.ApplyTo(newDonation);

      try
      {
        var finalizedDonation = await DonationService.Create(newDonation);
        return CreatedAtRoute("DefaultApi", new { controller = "Donation", id = finalizedDonation.Id }, new CompletedDonationApiModel(finalizedDonation));
      }
      catch (Exception e)
      {
        return InternalServerError(e);
      }
    }

    [HttpGet]
    [Route("api/donations")]
    [ResponseType(typeof(List<TransactionHistoryApiModel>))]
    public async Task<IHttpActionResult> GetAll()
    {
      var model = await AccountService.GetAllMyTransactions();
      var result = new List<TransactionHistoryApiModel>();
      foreach (var tx in model)
      {
        result.Add(new TransactionHistoryApiModel(tx));
      }

      return Ok(result);
    }

    [HttpGet]
    [Route("api/donate/{id:Guid}")]
    [ResponseType(typeof(CompletedDonationApiModel))]
    public async Task<IHttpActionResult> Get(Guid id)
    {

      var model = await DonationService.GetById(id);
      if (model == null)
      {
        return NotFound();
      }
      return Ok(new CompletedDonationApiModel(model));

    }
  }
}
