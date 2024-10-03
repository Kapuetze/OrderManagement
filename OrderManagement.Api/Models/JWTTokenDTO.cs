using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OrderManagement.Api.Models;
[DisplayName("JwtToken")]
public class JWTTokenDTO
{
    public string Token { get; set; }
    public DateTimeOffset Expires { get; set; }
}