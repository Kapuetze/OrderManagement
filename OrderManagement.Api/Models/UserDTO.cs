namespace OrderManagement.Api.Models;
public class UserDTO : BaseModelDTO
{
    public virtual ContactDTO Contact { get; set; }
    public string Email { get; set; }
}