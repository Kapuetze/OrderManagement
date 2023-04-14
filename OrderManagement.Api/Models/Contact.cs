using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Api.Models;

[DisplayName("Contact")]
public class ContactDTO : BaseModelDTO
{
    [StringLength(50)]
    public string? FirstName { get; set; }
    [StringLength(50)]
    public string? LastName { get; set; }
    [StringLength(150)]
    public string? Company { get; set; }
    [StringLength(100)]
    public string? Street { get; set; }
    [StringLength(100)]
    public string? City { get; set; }
    [StringLength(10)]
    public string? PostalCode { get; set; }
    [StringLength(100)]
    public string? Country { get; set; }
    [StringLength(100)]
    public string? State { get; set; }
    [StringLength(150)]
    public string? Email { get; set; }
    [StringLength(50)]
    public string? Phone { get; set; }
}