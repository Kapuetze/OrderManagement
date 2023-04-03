namespace OrderManagement.Core.Models;
public class Price : BaseModel
{
    public int PriceCategoryID { get; set; }
    public decimal Amount { get; set; }
    public string Name { get; set; }
}