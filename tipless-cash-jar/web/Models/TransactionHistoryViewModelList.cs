using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Syntax;
using tiplessCashJar.services.models;

namespace tiplessCashJar.web.Models
{
  public class TransactionHistoryViewModelList : List<TransactionHistoryViewModel>
  {
    public TransactionHistoryViewModelList(List<TransactionServiceModel> transactions)
    {
      foreach (var tx in transactions)
      {
        Add(new TransactionHistoryViewModel(tx));
      }
    }
  }

  public class TransactionHistoryViewModel
  {
    public TransactionHistoryViewModel(TransactionServiceModel tx)
    {
      Id = tx.Id;
      TxDate = tx.When.ToLocalTime().ToShortDateString();
      TxTime = tx.When.ToLocalTime().ToShortTimeString();
      Amount = tx.Amount.ToString("C");
    }

    public string Amount { get; set; }

    public string TxTime { get; set; }

    public string TxDate { get; set; }

    public Guid Id { get; set; }
  }
}