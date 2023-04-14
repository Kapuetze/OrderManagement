namespace OrderManagement.Core.Models;
public class Account : BaseModel
{
    public virtual Organisation Organisation { get; set; }

    // Each account can have a list of contacts to select from
    public virtual Contact? Contact { get; set; }

    public decimal Credit { get; set; }
}