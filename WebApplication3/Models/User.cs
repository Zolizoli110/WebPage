using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models;

public partial class User
{
    [Key]
    public string Id { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string DisplayName { get; set; }
}