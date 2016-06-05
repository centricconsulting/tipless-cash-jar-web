using System.Web.Mvc;
using tiplessCashJar.web.Core;

namespace tiplessCashJar.web.Controllers
{
  public class HomeController : AppControllerBase
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult Dashboard()
    {
      ViewBag.Message = "Dashboard page.";

      return View();
    }
  }
}