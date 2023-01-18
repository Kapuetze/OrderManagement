namespace OrderManagement.Core.Models;
public class BaseModel
{
    public int ID { get; set; }
    public Guid UniqueID { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime DateModified { get; set; }
}