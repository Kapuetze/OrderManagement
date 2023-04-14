namespace OrderManagement.Api.Models;
public class BaseModelDTO
{
    public Guid Id { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}