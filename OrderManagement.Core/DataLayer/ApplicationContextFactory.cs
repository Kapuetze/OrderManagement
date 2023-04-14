using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OrderManagement.Core.DataLayer;

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