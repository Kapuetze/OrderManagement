using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Core.ApplicationLayer.Accounts;
using OrderManagement.Core.DataLayer;

public static class ServiceCollectionExtensions
{
    public static void AddOrderManagementCore(this IServiceCollection services)
    {
        string connectionString = "server=localhost;database=ordermanagement;user=dbadmin;password=dbadmin";
        // Db context
        services.AddDbContext<ApplicationContext>(
            options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString), 
                // configure all queries to be split by default
                o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)));

        // Transients
        services.AddTransient<AccountLogic>();
    }
}