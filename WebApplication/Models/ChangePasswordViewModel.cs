using System.ComponentModel.DataAnnotations;

namespace WebApplication.Models
{
  public class ChangePasswordModel
  {
    [Required]
    public string Email { get; set; }
    
    public string CurrentPassword { get; set; }
    [Required]
    public string NewPassword { get; set; }
  }
}