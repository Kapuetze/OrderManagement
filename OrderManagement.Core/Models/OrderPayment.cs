namespace OrderManagement.Core.Models;
public class OrderPayment : BaseModel
{
    public int OrderID { get; set; }
    public DateTimeOffset Date { get; set; }
    public PaymentStatus Status { get; set; }
    public decimal Amount { get; set; }
    public int PaymentMethodID { get; set; }
    public string ExternalPaymentID { get; set; }
    public string Information { get; set; }
    public int TransactionID { get; set; }
}

public enum PaymentStatus 
{
    Created,
    Completed,
}