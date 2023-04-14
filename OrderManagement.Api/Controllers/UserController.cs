using Microsoft.AspNetCore.Mvc;
using OrderManagement.Core.ApplicationLogic.Accounts;
using OrderManagement.Core.ApplicationLogic.Users;
using OrderManagement.Core.Models;

namespace OrderManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ApiController<AccountController>
{
    readonly ILogger<AccountController> _logger;
    readonly UserLogic _userLogic;
    public UserController(ILogger<AccountController> logger, UserLogic userLogic)
    {
        _logger = logger;
        _userLogic = userLogic;
    }

//     [HttpPost]
//     public async Task Post(User user)
//     {
//         await _userLogic.Create(user);
//     }
}
