using System.ComponentModel.DataAnnotations;

namespace vContractors.Application.Models.Users;

public class LoginRequest
{
    [Required]
    public string UserName { get; set; }

    [Required]
    public string Password { get; set; }
}
