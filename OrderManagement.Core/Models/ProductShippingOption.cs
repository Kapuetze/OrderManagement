namespace OrderManagement.Core.Models;
public class ProductShippingOption : BaseModel
{
    public int ProductId { get; set; }
    public int ShippingOptionId { get; set; }
}