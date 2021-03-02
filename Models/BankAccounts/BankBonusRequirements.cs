using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurningTracker.Models.BankAccounts
{
  public enum BankBonusRequirementsType
  {
    RecurringDirectDeposit,
    TotalDirectDeposit,
    DebitCardTransactions
  }

  public class BankBonusRequirements
  {
    public BankBonusRequirementsType BonusRequirement { get; set; }

  }
}
