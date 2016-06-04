using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using tiplessCashJar.services;
using tiplessCashJar.services.models;
using tiplessCashJar.web.ApiModels;
using System.Threading.Tasks;
using tiplessCashJar.web.Core;

namespace tiplessCashJar.web.Api
{
    public class BeaconController : AppApiControllerBase
    {
        private IBeaconService BeaconService { get; set; }

        public BeaconController(IBeaconService beaconService) { BeaconService = beaconService; }

        [HttpGet]
        [Route("api/Beacons")]
        [ResponseType(typeof(List<BeaconApiModel>))]
        public async Task<IHttpActionResult> GetAllBeacons()
        {
            var beaconList = await BeaconService.GetAllBeacons();
            if (beaconList == null)
            {
                return NotFound();
            }
            return Ok(beaconList);
        }
    }
}
