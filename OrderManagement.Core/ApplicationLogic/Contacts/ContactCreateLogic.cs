using OrderManagement.Core.Models;
using OrderManagement.Core.DataLayer;
using Microsoft.EntityFrameworkCore;

namespace OrderManagement.Core.ApplicationLogic.Accounts;

public interface IContactCreateLogic
{
	Task Create(Contact contact);
}

internal class ContactCreateLogic : IContactCreateLogic
{
	ApplicationContext _dbContext;
    public ContactCreateLogic(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

	public async Task Create(Contact contact)
    {
        await _dbContext.Contacts.AddAsync(contact);
        await _dbContext.SaveChangesAsync();
    }  
}