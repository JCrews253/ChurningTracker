using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurningTracker.Models.BankAccounts
{
  public enum BankAccountType
  {
    Checking,
    Savings,
    Brokerage
  }

  public class BankAccount
  {
    [BsonId]
    public Guid Id { get; set; }
    public string BankName { get; set; }
    public string AccountName { get; set; }
    public BankAccountType AccountType { get; set; }
    public List<BankBonusRequirements> BonusRequirements { get; set; }
    public BankAccountFees Fee { get; set; }
    public DateTime DateApplied { get; set; }
    public DateTime DateClosed { get; set; }
    public string BonusLink { get; set; }
    public int BonusAmount { get; set; }
  }
}
