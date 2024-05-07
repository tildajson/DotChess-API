using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotChess_API.Dtos.Club
{
    public class UpdateClubRequestDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Minimum 5 characters required.")]
        [MaxLength(25, ErrorMessage = "Maximum characters exceeded.")]
        public required string ClubName { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Minimum 5 characters required.")]
        [MaxLength(25, ErrorMessage = "Maximum characters exceeded.")]
        public string ClubDescription { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Minimum 5 characters required.")]
        [MaxLength(280, ErrorMessage = "Maximum characters exceeded.")]
        public string Location { get; set; } = string.Empty;

        [Required]
        public int NumMembers { get; set; }
    }
}