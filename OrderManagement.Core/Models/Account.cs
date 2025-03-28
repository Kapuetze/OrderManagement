using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace OrderManagement.Core.Models;
public class Account : IdentityUser<int>, IBaseModel
{
    public Guid UniqueId { get; set; }
    public DateTime DateCreated { get; set; }
    
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DateModified { get; set; }
    
    public virtual Organisation Organisation { get; set; }

    // Each account can have a list of contacts to select from
    public virtual Contact? Contact { get; set; }

    public decimal Credit { get; set; }

    public Account()
    {
        UniqueId = Guid.NewGuid();
        DateCreated = DateTime.UtcNow;
    }
}