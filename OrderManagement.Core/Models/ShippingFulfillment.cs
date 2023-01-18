namespace OrderManagement.Core.Models;
public class Shipping : BaseModel
{
    public int OrderItemID { get; set; }
    public DateTimeOffset DateShipped { get; set; }
}