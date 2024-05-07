using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DotChess_API.Models;

namespace DotChess_API.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Minimum 5 characters required.")]
        [MaxLength(280, ErrorMessage = "Maximum characters exceeded.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Minimum 5 characters required.")]
        [MaxLength(280, ErrorMessage = "Maximum characters exceeded.")]
        public string Content { get; set; } = string.Empty;
    }
}