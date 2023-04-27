using Microsoft.AspNetCore.Identity;

namespace OrderManagement.Core.Models;
public class ManagementUser : BaseModel
{
    public virtual Contact Contact { get; set; }
    public string Email { get; set; }
}