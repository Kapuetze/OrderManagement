using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OrderManagement.Api.Models;
using OrderManagement.Core.ApplicationLogic.Accounts;
using OrderManagement.Core.ApplicationLogic.Users;
using OrderManagement.Core.Models;

namespace OrderManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ApiController<AccountController>
{
    readonly ILogger<AccountController> _logger;
    readonly IMapper _mapper;
    readonly UserLogic _userLogic;
    public UserController(ILogger<AccountController> logger, IMapper mapper, UserLogic userLogic)
    {
        _logger = logger;
        _mapper = mapper;
        _userLogic = userLogic;
    }

    [HttpPost]
    public async Task<IActionResult> Post(UserDTO user, string password)
    {
        var newUser = _mapper.Map<ApplicationUser>(user);
        var result = await _userLogic.Create(newUser, password);
        if (!result.Succeeded)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.Code, error.Description);
            }
            return ValidationProblem(ModelState);
        }

        return CreatedAtAction(nameof(Get), newUser);
    }

    [HttpGet]
    public async Task<UserDTO> Get(Guid id)
    {
        var user = await _userLogic.Get(id);
        var userDto = _mapper.Map<UserDTO>(user);
        return userDto;
    }
}
