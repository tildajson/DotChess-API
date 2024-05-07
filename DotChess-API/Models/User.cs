using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace DotChess_API.Models
{
    [Table("Users")]
    public class User : IdentityUser
    {
        public int ELORating { get; set; }
        public int? ClubId { get; set; }
        public Club? Club { get; set; }
    }
}
