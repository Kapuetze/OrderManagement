using Microsoft.AspNetCore.Mvc;
using OrderManagement.Core.ApplicationLayer.Accounts;
using OrderManagement.Core.Models;

namespace OrderManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ApiController<AccountController>
{
    readonly ILogger<AccountController> _logger;
    readonly AccountLogic _accountLogic;
    public AccountController(ILogger<AccountController> logger, AccountLogic accountLogic)
    {
        _logger = logger;
        _accountLogic = accountLogic;
    }

    [HttpGet]
    public async Task<IEnumerable<Account>> Get()
    {
        var accounts = await _accountLogic.GetList(0);
        return accounts;
    }

    [HttpGet("{id}")]
    public async Task<Account> Get(Guid id)
    {
        var account = await _accountLogic.Get(id);
        return account;
    }

    [HttpPost]
    public async Task Post(Account account)
    {
        await _accountLogic.Create(account);
    }
}
