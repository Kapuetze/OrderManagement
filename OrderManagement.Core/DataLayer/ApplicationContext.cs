using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OrderManagement.Core.Models;

namespace OrderManagement.Core.DataLayer;

public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
{
    public ApplicationContext CreateDbContext(string[] args)
    {
        string connectionString = "server=localhost;database=ordermanagement;user=dbadmin;password=dbadmin";
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), 
            // configure all queries to be split by default
            o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));

        return new ApplicationContext(optionsBuilder.Options);
    }
}

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Organisation> Organisations { get; set; }
    // public DbSet<Product> Products { get; set; }
}

