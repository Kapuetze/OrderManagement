namespace OrderManagement.Core.Models;
public class OrderPayment : BaseModel
{
    public Order Order { get; set; }
    public DateTimeOffset Date { get; set; }
    public PaymentStatus Status { get; set; }
    public decimal Amount { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
    public string ExternalPaymentID { get; set; }
    public string Information { get; set; }
    public Transaction Transaction { get; set; }
}

public enum PaymentStatus 
{
    Created,
    Completed,
}