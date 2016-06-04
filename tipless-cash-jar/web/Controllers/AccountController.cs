using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using tiplessCashJar.services;
using tiplessCashJar.web.Core;
using tiplessCashJar.web.Models;

namespace tiplessCashJar.web.Controllers
{
  public class AccountController : AppControllerBase
  {
    private IAccountService AccountService { get; set; }

    public AccountController(IAccountService accountService) { AccountService = accountService; }

    [HttpPost]
    public ActionResult Register()
    {
      return RedirectToAction("Dashboard", "Home");
    }

    [HttpPost]
    public ActionResult Login()
    {
      return RedirectToAction("Dashboard", "Home");
    }

    public ActionResult Settings()
    {
      return View();
    }

    [HttpPost]
    [ActionName("Settings")]
    public ActionResult SettingsSave()
    {
      return View();
    }

    public async Task<ActionResult> ActivityHistory()
    {
      var transactions = await AccountService.GetAllMyTransactions();
      var model = new TransactionHistoryViewModelList(transactions.OrderByDescending(tx => tx.When).ToList());

      return View("ActivityHistory", model);
    }
  }
}