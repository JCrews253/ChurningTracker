using ChurningTracker.Models.BankAccounts;
using ChurningTracker.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ChurningTracker.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BankAccountController
  {
    private readonly IUserService _userService;
    private MongoDb _db;

    public BankAccountController(IUserService userService)
    {
      _userService = userService;
      var userId = _userService.GetUserId() ?? "00000000-0000-0000-0000-000000000000";
      _db = new MongoDb(userId);
    }

    [HttpGet]
    public IEnumerable<BankAccount> GetAccounts()
    {
      return _db.GetRecords<BankAccount>("BankAccounts");
    }

    [HttpGet("{id}")]
    public BankAccount GetAccount(Guid id)
    {
      return _db.GetRecord<BankAccount>("BankAccounts", id);
    }

    [HttpPut]
    public void InsertAccount(BankAccount account)
    {
      if(account.Id.ToString() == "00000000-0000-0000-0000-000000000000")
      {
        account.Id = new Guid();
      }
      _db.Insert("BankAccounts", account);
    }

    [HttpPost]
    public void UpsertAccount(BankAccount account)
    {
      _db.UpsertRecord<BankAccount>("BankAccounts", account.Id, account);
    }

    [HttpDelete]
    public void DeleteAccount(Guid id)
    {
      _db.Delete<BankAccount>("BankAccounts", id);
    }
  }
}
