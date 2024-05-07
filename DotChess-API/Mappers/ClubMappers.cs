using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotChess_API.Dtos.Club;
using DotChess_API.Models;

namespace DotChess_API.Mappers
{
    public static class ClubMappers
    {
        public static ClubDto ToClubDto(this Club clubModel)
        {
            return new ClubDto
            {
                Id = clubModel.Id,
                ClubName = clubModel.ClubName,
                ClubDescription = clubModel.ClubDescription,
                Location = clubModel.Location,
                NumMembers = clubModel.NumMembers,
                Comments = clubModel.Comments.Select(c => c.ToCommentDto()).ToList()
            };
        }

        public static Club ToClubFromCreateDto(this CreateClubRequestDto clubDto)
        {
            return new Club
            {
                ClubName = clubDto.ClubName,
                ClubDescription = clubDto.ClubDescription,
                Location = clubDto.Location,
                NumMembers = clubDto.NumMembers
            };
        }
    }
}