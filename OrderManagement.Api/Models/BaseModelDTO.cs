using System.ComponentModel;
using Microsoft.AspNetCore.OpenApi;
using Swashbuckle.AspNetCore.Annotations;

namespace OrderManagement.Api.Models;
public class BaseModelDTO
{
    [SwaggerSchema(ReadOnly = true)]
    public Guid Id { get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public DateTime DateCreated { get; set; }
    [SwaggerSchema(ReadOnly = true)]
    public DateTime DateModified { get; set; }
}