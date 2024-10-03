using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace OrderManagement.Core.Models;
public class ApplicationUser : IdentityUser<int>, IBaseModel
{
	public Guid UniqueId { get; set; }
	public DateTime DateCreated { get; set; }

	[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
	public DateTime DateModified { get; set; }

	public ApplicationUser()
	{
		UniqueId = Guid.NewGuid();
		DateCreated = DateTime.UtcNow;
	}
}