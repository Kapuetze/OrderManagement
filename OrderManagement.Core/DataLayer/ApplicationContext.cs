using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OrderManagement.Core.Models;

namespace OrderManagement.Core.DataLayer;

public class ApplicationContext : DbContext
{
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Organisation> Organisations { get; set; }
    public DbSet<ApplicationUser> Users { get; set; }
    // public DbSet<Product> Products { get; set; }
}

