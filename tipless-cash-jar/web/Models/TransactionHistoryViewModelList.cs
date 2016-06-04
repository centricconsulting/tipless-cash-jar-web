using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
      //Id = tx.Id;
      //Date = tx.
    }
  }
}