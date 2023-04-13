
using OrderManagement.Core.Models;
using OrderManagement.Core.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace OrderManagement.Core.ApplicationLayer.Accounts;

public class AccountLogic
{
    ApplicationContext _dbContext;
    public AccountLogic(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Account> Get(Guid id)
    {
        var account = await _dbContext.Accounts.SingleOrDefaultAsync(i => i.UniqueId == id);
        return account;
    }

    public async Task<IEnumerable<Account>> GetList(int organisationId)
    {
        var accounts = await _dbContext.Accounts.Where(i => i.Organisation.Id == organisationId).ToListAsync();
        return accounts;
    }

    public async Task Create(Account account)
    {
        await _dbContext.Accounts.AddAsync(account);
        await _dbContext.SaveChangesAsync();
    }  
}