using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Api.Models;
[DisplayName("User")]
public class UserDTO : BaseModelDTO
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string UserName { get; set; }

    // public virtual ContactDTO Contact { get; set; }
}