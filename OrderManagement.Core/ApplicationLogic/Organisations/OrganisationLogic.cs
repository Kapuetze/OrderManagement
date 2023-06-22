
using OrderManagement.Core.Models;
using OrderManagement.Core.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace OrderManagement.Core.ApplicationLogic.Accounts;

public interface IOrganisationLogic
{
	Task<Organisation> Get(Guid id);
	Task Create(Organisation organisation);
}

internal class OrganisationLogic : IOrganisationLogic
{
    ApplicationContext _dbContext;
    public OrganisationLogic(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Organisation> Get(Guid id)
    {
        var entity = await _dbContext.Organisations.SingleOrDefaultAsync(i => i.UniqueId == id);
        return entity;
    }

    public async Task Create(Organisation organisation)
    {
        await _dbContext.Organisations.AddAsync(organisation);
        await _dbContext.SaveChangesAsync();
    }  
}