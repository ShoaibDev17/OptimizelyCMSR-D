using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project.Models;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; }

    [Required]
    public string Password { get; set; }
}
