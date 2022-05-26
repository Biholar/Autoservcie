using System.Security.AccessControl;

namespace Autoservice.Infrastructure.Models;

public class ServiceRequest
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string SecondName { get; set; }
    public string PhoneNum { get; set; }
    public string Email { get; set; }
    public string ProblemDesc { get; set; }
    public int Statement { get; set; }
}