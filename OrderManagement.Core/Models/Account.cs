namespace OrderManagement.Core.Models;
public class Account : BaseModel
{
    public int OrganisationID { get; set; }

    // Each account can have a list of contacts to select from
    public int ContactID { get; set; }
}