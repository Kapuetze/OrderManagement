// using OrderManagement.Core.ApplicationLogic.Users;
// using OrderManagement.Core.Models;

// namespace OrderManagement.Core.Tests.ApplicationLayer.Users;

// public class UserLogicTests
// {
// 	UserLogic _userLogic;

// 	[Fact]
// 	public async Task ValidUserIsInserted()
// 	{
// 		ApplicationUser newUser = new ApplicationUser
// 		{
// 			UserName = "Test",
// 			Email = "test@test.de"
// 		};

// 		var result = await _userLogic.Create(newUser, "test12345");
// 		Assert.True(result.Succeeded);
// 	}

// 	[Fact]
// 	public async Task InvalidUserThrowsError()
// 	{
// 		ApplicationUser newUser = new ApplicationUser
// 		{
// 			UserName = "Test",
// 			Email = "invalid"
// 		};

// 		var result = await _userLogic.Create(newUser, "1");
// 		var errors = result.Errors.Select(i => i.Code);
		
// 		var expected = new List<string> 
// 		{
// 			"", "", ""
// 		};

// 		Assert.Equivalent(expected, errors);
// 		Assert.False(result.Succeeded);
// 	}
// }