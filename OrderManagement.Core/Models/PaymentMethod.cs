namespace OrderManagement.Core.Models;
public class PaymentMethod : BaseModel
{
    public int PaymentGatewayID { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
}