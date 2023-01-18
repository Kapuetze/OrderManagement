namespace OrderManagement.Core.Models;

/// <summary>
/// Shipping options that can be set up by organisation
/// </summary>
public class ShippingOption : BaseModel
{
    public int OrganisationID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public ShippingOption()
    {
        Name = "";
    }
}