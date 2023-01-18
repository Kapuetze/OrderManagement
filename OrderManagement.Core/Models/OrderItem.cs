namespace OrderManagement.Core.Models;
public class OrderItem : BaseModel
{
    public int OrderID { get; set; }
    public int ProductID { get; set; }
    public int PriceGroupDetailID { get; set; }
}