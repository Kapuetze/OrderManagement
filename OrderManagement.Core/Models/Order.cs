namespace OrderManagement.Core.Models;
public class Order : BaseModel
{
    public virtual Organisation Organisation { get; set; }
    public virtual Account Account { get; set; }
    public DateTimeOffset Date { get; set; }
    public OrderStatus Status { get; set; }
    public Contact BillingContact { get; set; }
    public Contact ShippingContact { get; set; }
}

public enum OrderStatus
{
    Created,
    Completed
}