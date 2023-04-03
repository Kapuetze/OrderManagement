using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OrderManagement.Core.DataLayer;

public static class ServiceCollectionExtensions
{
    public static void AddOrderManagementCore(this IServiceCollection services)
    {
        // Transients
        services.AddDbContext<ApplicationContext>(
            options => options.UseMySQL("server=localhost;database=library;user=user;password=password"));
    }
}