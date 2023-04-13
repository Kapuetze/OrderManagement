using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Core.Models;
public class BaseModel
{
    [Key]
    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}