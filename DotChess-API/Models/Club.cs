using System.ComponentModel.DataAnnotations.Schema;

namespace DotChess_API.Models
{
    [Table("Clubs")]
    public class Club
    {

        public int Id { get; set; }
        public required string ClubName { get; set; } = string.Empty;
        public string ClubDescription { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int NumMembers { get; set; }
        public List<User> Users { get; set; } = new List<User>();
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}
