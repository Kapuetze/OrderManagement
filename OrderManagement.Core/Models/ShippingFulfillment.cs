namespace OrderManagement.Core.Models;
public class Shipping : BaseModel
{
    public int OrderItemId { get; set; }
    public DateTimeOffset DateShipped { get; set; }
}