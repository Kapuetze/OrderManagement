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

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Account> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Account
        {
            
        })
        .ToArray();
    }
}
