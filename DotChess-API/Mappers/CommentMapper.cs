using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotChess_API.Dtos.Comment;
using DotChess_API.Models;

namespace DotChess_API.Mappers
{
    public static class CommentMapper
    {
        public static CommentDto ToCommentDto(this Comment commentModel)
        {
            return new CommentDto
            {
                Id = commentModel.Id,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                CreatedBy = commentModel.User.UserName,
                ClubId = commentModel.ClubId
            };
        }

        public static Comment ToCommentFromCreate(this CreateCommentDto commentDto, int clubId)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content,
                ClubId = clubId
            };
        }

        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDto commentDto)
        {
            return new Comment
            {
                Title = commentDto.Title,
                Content = commentDto.Content
            };
        }
    }
}