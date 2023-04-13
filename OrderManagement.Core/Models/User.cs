namespace OrderManagement.Core.Models;
public class User : BaseModel
{
    public virtual Contact Contact { get; set; }
    public string Email { get; set; }
}