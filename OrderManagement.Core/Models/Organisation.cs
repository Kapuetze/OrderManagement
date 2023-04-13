using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Core.Models;
public class Organisation : BaseModel
{
    [StringLength(150)]
    public string Name { get; set; }
    public Organisation ParentOrganisation { get; set; }
    public Contact Contact { get; set; }
}
