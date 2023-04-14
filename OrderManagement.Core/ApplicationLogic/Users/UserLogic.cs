
using OrderManagement.Core.Models;
using OrderManagement.Core.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace OrderManagement.Core.ApplicationLogic.Users;

public class UserLogic
{
    ApplicationContext _dbContext;
    public UserLogic(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Create(User user)
    {
        await _dbContext.Users.AddAsync(user);
        await _dbContext.SaveChangesAsync();
    }  
}