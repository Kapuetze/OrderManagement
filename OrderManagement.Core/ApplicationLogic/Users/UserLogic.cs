
using OrderManagement.Core.Models;
using OrderManagement.Core.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace OrderManagement.Core.ApplicationLogic.Users;

public class UserLogic
{
    ApplicationContext _dbContext;
    UserManager<ApplicationUser> _userManager;
    public UserLogic(ApplicationContext dbContext, UserManager<ApplicationUser> userManager)
    {
        _dbContext = dbContext;
        _userManager = userManager;
    }

    public async Task<IdentityResult> Create(ApplicationUser user, string password)
    {
        return await _userManager.CreateAsync(user, password);     
    }

    public async Task<ApplicationUser?> Get(Guid id)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(i => i.UniqueId == id);
    }
}