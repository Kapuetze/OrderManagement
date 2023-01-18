namespace OrderManagement.Core.Models;
public class Product : BaseModel
{
    public int OrganisationID { get; set; }
    public int PriceGroupID { get; set; }
}