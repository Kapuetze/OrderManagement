namespace OrderManagement.Core.Models;
public class Organisation : BaseModel
{
    public string Name { get; set; }
    public int ParentOrganisationID { get; set; }
    public int AddressID { get; set; }
}
