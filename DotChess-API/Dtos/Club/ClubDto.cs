using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotChess_API.Dtos.Comment;

namespace DotChess_API.Dtos.Club
{
    public class ClubDto
    {
        public int Id { get; set; }
        public required string ClubName { get; set; } = string.Empty;
        public string ClubDescription { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int NumMembers { get; set; }
        public List<CommentDto> Comments { get; set; }
    }
}