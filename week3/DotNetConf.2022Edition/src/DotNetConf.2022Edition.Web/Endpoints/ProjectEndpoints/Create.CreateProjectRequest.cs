using System.ComponentModel.DataAnnotations;

namespace DotNetConf._2022Edition.Web.Endpoints.ProjectEndpoints;

public class CreateProjectRequest
{
  public const string Route = "/Projects";

  [Required]
  public string? Name { get; set; }
}
