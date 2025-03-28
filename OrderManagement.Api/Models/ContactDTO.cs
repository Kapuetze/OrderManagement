using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Api.Models;

[DisplayName("Contact")]
public class ContactDTO : BaseModelDTO
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Company { get; set; }
    public string? Street { get; set; }
    public string? City { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public string? State { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
}