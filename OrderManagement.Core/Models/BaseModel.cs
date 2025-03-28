using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Core.Models;

public interface IBaseModel
{
    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}

public class BaseModel : IBaseModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public DateTime DateCreated { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DateModified { get; set; }

    protected BaseModel()
    {
        UniqueId = Guid.NewGuid();
        DateCreated = DateTime.UtcNow;
    }
}