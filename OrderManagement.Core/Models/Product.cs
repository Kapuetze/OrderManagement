namespace OrderManagement.Core.Models;
public class Product : BaseModel
{
    public int OrganisationId { get; set; }
    public int PriceGroupId { get; set; }
}