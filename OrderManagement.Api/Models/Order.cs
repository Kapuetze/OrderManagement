namespace OrderManagement.Api.Models;
public class OrderDTO : BaseModelDTO
{
    public Guid OrganisationId { get; set; }
    public AccountDTO Account { get; set; }
    public DateTimeOffset Date { get; set; }
    public OrderStatus Status { get; set; }
    public ContactDTO BillingContact { get; set; }
    public ContactDTO ShippingContact { get; set; }
}

public enum OrderStatus
{
    Created,
    Completed
}