using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace learning.Models;

public class MessageModel
{
    [Key]
    public DateTime DnT { get; set; } = DateTime.Now;
    [Required]
    [DisplayName("Name")]
    public string CustomerName { get; set; }
    [Required]
    [PhoneAttribute]
    public string Phone { get; set; }
    [Required]
    [EmailAddressAttribute]
    public string Email { get; set; }
    [Required]
    public string Subject { get; set; }
    [Required]
    public string Message { get; set; }
}
