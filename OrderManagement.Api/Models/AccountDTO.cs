using System.ComponentModel;

namespace OrderManagement.Api.Models;

[DisplayName("Account")]
public class AccountDTO : BaseModelDTO
{
    // Each account can have a list of contacts to select from
    public virtual ContactDTO Contact { get; set; }

    public decimal Credit { get; set; }
}