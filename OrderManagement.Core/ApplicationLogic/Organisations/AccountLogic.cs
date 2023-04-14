
using OrderManagement.Core.Models;
using OrderManagement.Core.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace OrderManagement.Core.ApplicationLogic.Accounts;

public class OrganisationLogic
{
    ApplicationContext _dbContext;
    public OrganisationLogic(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Organisation> Get(Guid id)
    {
        var account = await _dbContext.Organisations.SingleOrDefaultAsync(i => i.UniqueId == id);
        return account;
    }

    public async Task Create(Organisation account)
    {
        await _dbContext.Organisations.AddAsync(account);
        await _dbContext.SaveChangesAsync();
    }  
}