using System;
using tiplessCashJar.services.models;

namespace tiplessCashJar.web.ApiModels
{
  public class TransactionHistoryApiModel
  {
    public TransactionHistoryApiModel(TransactionServiceModel tx)
    {
      Id = tx.Id;
      TxDate = tx.When;
      Amount = tx.Amount;
    }

    public int Amount { get; set; }

    public DateTime TxDate { get; set; }

    public Guid Id { get; set; }
  }
}