namespace OrderManagement.Core.Models;
public class PriceCategory : BaseModel
{
    public int OrganisationID { get; set; }
    public string Color { get; set; }
    public string Notes { get; set; }
}