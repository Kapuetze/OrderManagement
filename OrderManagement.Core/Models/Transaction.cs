namespace OrderManagement.Core.Models;
public class Transaction : BaseModel
{
    public TransactionType Type { get; set; }
    public DateTimeOffset Date { get; set; }
    public int IncrementingId { get; set; }
    public string Prefix { get; set; }

    public string GetTransactionString() => Prefix + IncrementingId.ToString();
}

public enum TransactionType 
{
    Sale,
    Refund,
}