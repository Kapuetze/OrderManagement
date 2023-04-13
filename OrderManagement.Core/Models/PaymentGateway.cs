namespace OrderManagement.Core.Models;
public class PaymentGateway : BaseModel
{
    public Organisation Organisation { get; set; }
    public PaymentGatewayType Type { get; set; }
    public string? Identifier { get; set; }
    public string? ApiKey { get; set; }

    /* OAuth Values */
    public string? AccessToken { get; set; }
    public string? RefreshToken { get; set; }
    public DateTimeOffset? AccessTokenExpiryDate { get; set; }
    public DateTimeOffset? RefreshTokenExpiryDate { get; set; }
}

public enum PaymentGatewayType
{
    PayPal,
    Stripe
}