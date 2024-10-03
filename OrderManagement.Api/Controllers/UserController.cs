using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
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
	readonly IConfiguration _configuration;
	public UserController(ILogger<AccountController> logger, IMapper mapper, UserLogic userLogic, IConfiguration configuration)
	{
		_logger = logger;
		_mapper = mapper;
		_userLogic = userLogic;
		_configuration = configuration;
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
	[Authorize]
	public async Task<UserDTO> Get()
	{
		var user = await _userLogic.Get(new Guid(User.Claims.First(i => i.Type == ClaimTypes.NameIdentifier).Value));
		var userDto = _mapper.Map<UserDTO>(user);
		return userDto;
	}

	[HttpPost]
	[Route("Authorize")]
	public async Task<IActionResult> Login(string email, string password)
	{
		var user = await _userLogic.GetByEmail(email);
		if (user != null)
		{
			bool passwordValid = await _userLogic.CheckPassword(user, password);
			if (passwordValid)
			{
				JWTTokenDTO token = GenerateToken(user);

				return Ok(token);
			}
		}

		return BadRequest("Invalid credentials");
	}


	private JWTTokenDTO GenerateToken(ApplicationUser user)
	{
		var handler = new JwtSecurityTokenHandler();
		var key = Encoding.ASCII.GetBytes(_configuration["Auth:JwtSecret"]);
		var credentials = new SigningCredentials(
			new SymmetricSecurityKey(key),
			SecurityAlgorithms.HmacSha256Signature);

		DateTime expires = DateTime.UtcNow.AddMinutes(15);
		var tokenDescriptor = new SecurityTokenDescriptor
		{
			Subject = GenerateClaims(user),
			Expires = expires,
			SigningCredentials = credentials,
		};

		var token = handler.CreateToken(tokenDescriptor);
		return new JWTTokenDTO { Token = handler.WriteToken(token), Expires = new DateTimeOffset(expires) };
	}

	private static ClaimsIdentity GenerateClaims(ApplicationUser user)
	{
		var claims = new ClaimsIdentity();
		claims.AddClaim(new Claim(ClaimTypes.Name, user.Email));
		claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.UniqueId.ToString()));

		// foreach (var role in user.Roles)
		//     claims.AddClaim(new Claim(ClaimTypes.Role, role));

		return claims;
	}
}
