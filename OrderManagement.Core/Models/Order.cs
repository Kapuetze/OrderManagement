namespace OrderManagement.Core.Models;
public class Order : BaseModel
{
    public int OrganisationID { get; set; }
    public int AccountID { get; set; }
    public DateTimeOffset Date { get; set; }
    public OrderStatus Status { get; set; }
    public int BillingContactID { get; set; }
    public int ShippingContactID { get; set; }
}

public enum OrderStatus
{
    Created,
    Completed
}