using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models;

public partial class User
{
    [Key]
    public string Email { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public bool IsAdmin { get; set; }
    
}