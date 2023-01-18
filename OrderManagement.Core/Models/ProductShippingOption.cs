namespace OrderManagement.Core.Models;
public class ProductShippingOption : BaseModel
{
    public int ProductID { get; set; }
    public int ShippingOptionID { get; set; }
}