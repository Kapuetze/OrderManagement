using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Core.ApplicationLogic.Accounts;
using OrderManagement.Core.ApplicationLogic.Users;
using OrderManagement.Core.DataLayer;
using OrderManagement.Core.Models;

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

        // Add identity
        services.AddIdentityCore<ApplicationUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.User.RequireUniqueEmail = true;
            options.Password.RequireDigit = false;
            options.Password.RequiredLength = 6;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireLowercase = false;
        })
        // .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<ApplicationContext>();

        services.AddIdentityCore<Account>()
            .AddEntityFrameworkStores<ApplicationContext>();

        // Transients
        services.AddTransient<AccountLogic>();
        services.AddTransient<OrganisationLogic>();
        services.AddTransient<UserLogic>();
    }
}