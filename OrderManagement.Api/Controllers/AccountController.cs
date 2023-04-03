using Microsoft.AspNetCore.Mvc;
using OrderManagement.Core.Models;

namespace OrderManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController : ApiController<AccountController>
{
    readonly ILogger<AccountController> _logger;
    public AccountController(ILogger<AccountController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<Account>> Get()
    {
        return new List<Account>();
    }

    [HttpPost]
    public async Task Post(Account account)
    {

    }
}
