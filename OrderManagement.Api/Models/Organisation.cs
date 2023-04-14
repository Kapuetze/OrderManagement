using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Api.Models;
public class OrganisationDTO : BaseModelDTO
{
    [StringLength(150)]
    public string Name { get; set; }
    public Guid ParentOrganisationId { get; set; }
    public ContactDTO Contact { get; set; }
}
