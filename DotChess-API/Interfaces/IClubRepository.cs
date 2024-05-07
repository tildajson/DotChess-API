using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotChess_API.Dtos.Club;
using DotChess_API.Helpers;
using DotChess_API.Models;

namespace DotChess_API.Interfaces
{
    public interface IClubRepository
    {
        Task<List<Club>> GetAllAsync(QueryObject query);
        Task<Club?> GetByIdAsync(int id);
        Task<Club?> GetByLocationAsync(string location);
        Task<Club> CreateAsync(Club clubModel);
        Task<Club?> UpdateAsync(int id, UpdateClubRequestDto clubDto);
        Task<Club?> DeleteAsync(int id);
        Task<bool> ClubExists(int id);
    }
}