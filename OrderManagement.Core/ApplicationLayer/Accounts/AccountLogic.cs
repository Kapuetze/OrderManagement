
using OrderManagement.Core.Models;
using OrderManagement.Core.DataLayer;

namespace OrderManagement.Core.ApplicationLayer.Accounts;

public class AccountLogic
{
    ApplicationContext _dbContext;
    public AccountLogic(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Create(Account account)
    {
        await _dbContext.Accounts.AddAsync(account);
        await _dbContext.SaveChangesAsync();
    }
}