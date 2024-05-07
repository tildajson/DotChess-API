using DotChess_API.Data;
using DotChess_API.Dtos.Club;
using DotChess_API.Helpers;
using DotChess_API.Interfaces;
using DotChess_API.Mappers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotChess_API.Controllers
{
    [Route("api/club")]
    [ApiController]
    public class ClubController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        private readonly IClubRepository _clubRepo;
        public ClubController(ApplicationDBContext context, IClubRepository clubRepo)
        {
            _clubRepo = clubRepo;
            _context = context;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAll([FromQuery] QueryObject query)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var clubs = await _clubRepo.GetAllAsync(query);

            var clubDto = clubs.Select(s => s.ToClubDto()).ToList();

            return Ok(clubs);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var club = await _clubRepo.GetByIdAsync(id);

            if (club == null)
            {
                return NotFound();
            }

            return Ok(club.ToClubDto());
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Create([FromBody] CreateClubRequestDto clubDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var clubModel = clubDto.ToClubFromCreateDto();
            await _clubRepo.CreateAsync(clubModel);
            return CreatedAtAction(nameof(GetById), new { id = clubModel.Id }, clubModel.ToClubDto());
        }

        [HttpPut]
        [Route("{id:int}")]
        [Authorize]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] UpdateClubRequestDto updateDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var clubModel = await _clubRepo.UpdateAsync(id, updateDto);

            if (clubModel == null)
            {
                return NotFound();
            }

            return Ok(clubModel.ToClubDto());
        }

        [HttpDelete]
        [Route("{id:int}")]
        [Authorize]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var clubModel = await _clubRepo.DeleteAsync(id);

            if (clubModel == null)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
