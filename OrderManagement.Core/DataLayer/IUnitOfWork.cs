using OrderManagement.Core.DataLayer.Repositories;

namespace OrderManagement.Core.DataLayer;
public interface IUnitOfWork
{
    public IAccountRepository Accounts { get; }
    public IOrderRepository Orders { get; }
    public Task<int> Complete();
    public void Dispose();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationContext _context;

    // Repositories
    public IAccountRepository Accounts { get; }
    public IOrderRepository Orders { get; }

    public UnitOfWork(ApplicationContext context)
    {
        _context = context;
        // Accounts = new AccountRepository(_context);
        // Orders = new ProjectRepository(_context);
    }

    public IAccountRepository Account { get; private set; }
    public IOrderRepository Order { get; private set; }
    public async Task<int> Complete()
    {
        return await _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}