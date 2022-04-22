using System.ComponentModel.DataAnnotations;
namespace learning.Models;


public class UserModel
{
    ///<summary>
    /// Gets or sets PersonId.
    ///</summary> 
    [Key]
    public int UserID { get; set; }

    // /<summary>
    // / Gets or sets Name.
    // /</summary>
    [Required]
    public string Name { get; set; }

    ///<summary>
    /// Gets or sets Password.
    ///</summary>
    [Required]
    public string Password { get; set; }

    public string Role { get; set; }

    public int Right { get; set; }
}
