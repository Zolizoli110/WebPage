using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Models;

public partial class Reservation
{
    [Key]
    public string Id { get; set; }
    [Required]
    public DateTime Start { get; set; }
    [Required]
    public DateTime End { get; set; } 
    [Required]
    public string Title { get; set; }
    [ForeignKey("User")]
    public string AuthorId { get; set; }
    public virtual User User { get; set; }
    [Required]
    public string Text { get; set; }
}