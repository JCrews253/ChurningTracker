using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChurningTracker.Models.BankAccounts
{
  public class BankAccountFees
  {
    public bool Avoidable { get; set; }
    public int Amount { get; set; }
    public int DirectDepositAmountToAvoid { get; set; }
  }
}
