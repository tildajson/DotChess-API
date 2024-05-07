using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotChess_API.Data;
using DotChess_API.Dtos.Club;
using DotChess_API.Helpers;
using DotChess_API.Interfaces;
using DotChess_API.Models;
using Microsoft.EntityFrameworkCore;

namespace DotChess_API.Respository
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDBContext _context;
        public ClubRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public Task<bool> ClubExists(int id)
        {
            return _context.Club.AnyAsync(s => s.Id == id);
        }

        public async Task<Club> CreateAsync(Club clubModel)
        {
            await _context.Club.AddAsync(clubModel);
            await _context.SaveChangesAsync();

            return clubModel;
        }

        public async Task<Club?> DeleteAsync(int id)
        {
            var clubModel = await _context.Club.FirstOrDefaultAsync(x => x.Id == id);

            if (clubModel == null)
            {
                return null;
            }

            _context.Club.Remove(clubModel);
            await _context.SaveChangesAsync();

            return clubModel;
        }

        public async Task<List<Club>> GetAllAsync(QueryObject query)
        {
            var clubs = _context.Club.Include(c => c.Comments).ThenInclude(u => u.User).AsQueryable();

            if (!string.IsNullOrWhiteSpace(query.ClubName))
            {
                clubs = clubs.Where(s => s.ClubName.Contains(query.ClubName));
            }

            if (!string.IsNullOrWhiteSpace(query.Location))
            {
                clubs = clubs.Where(s => s.Location.Contains(query.Location));
            }

            if (!string.IsNullOrWhiteSpace(query.SortBy))
            {
                if (query.SortBy.Equals("ClubName", StringComparison.OrdinalIgnoreCase))
                {
                    clubs = query.IsDescending ? clubs.OrderByDescending(c => c.ClubName) : clubs.OrderBy(c => c.ClubName);
                }
            }

            var skipNumber = (query.PageNumber - 1) * query.PageSize;

            return await clubs.Skip(skipNumber).Take(query.PageSize).ToListAsync();
        }

        public async Task<Club?> GetByIdAsync(int id)
        {
            return await _context.Club.Include(c => c.Comments).FirstOrDefaultAsync(i => i.Id == id);
        }

        public async Task<Club?> GetByLocationAsync(string location)
        {
            return await _context.Club.FirstOrDefaultAsync(l => l.Location == location);
        }

        public async Task<Club?> UpdateAsync(int id, UpdateClubRequestDto clubDto)
        {
            var existingClub = await _context.Club.FirstOrDefaultAsync(x => x.Id == id);

            if (existingClub == null)
            {
                return null;
            }

            existingClub.ClubName = clubDto.ClubName;
            existingClub.ClubDescription = clubDto.ClubDescription;
            existingClub.Location = clubDto.Location;
            existingClub.NumMembers = clubDto.NumMembers;

            await _context.SaveChangesAsync();

            return existingClub;
        }
    }
}