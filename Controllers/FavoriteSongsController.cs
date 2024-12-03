using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalProject.Data;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoriteSongsController : ControllerBase
    {
        private readonly FinalProjectContext _context;

        public FavoriteSongsController(FinalProjectContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult GetFavoriteSongs()
        {
            var favoriteSongs = _context.FavoriteSong.Include(fs => fs.TeamMember).ToList();
            return Ok(favoriteSongs);
        }

        
        [HttpGet("{id}")]
        public IActionResult GetFavoriteSong(int id)
        {
            var favoriteSong  = _context.FavoriteSong.Find(id);
            if (id == 0 || favoriteSong == null)
            {
                var results = _context.FavoriteSong.Take(5).ToList();
                return Ok(results);
            }
            else
            {
                return Ok(favoriteSong);
            }
        }

        
        [HttpPost]
        public IActionResult PostFavoriteSong(FavoriteSong favoriteSong)
        {
            _context.FavoriteSong.Add(favoriteSong);
            _context.SaveChanges();
            return Ok(favoriteSong);
        }

        
        [HttpPut]
        public IActionResult PutFavoriteSong(FavoriteSong favoriteSong)
        {
            try
            {
                _context.Entry(favoriteSong).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok(favoriteSong);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        
        [HttpDelete("{id}")]
        public IActionResult DeleteFavoriteSong(int id)
        {
            var favoriteSong = _context.FavoriteSong.Find(id);
            if (favoriteSong == null)
            {
                return NotFound();
            }
            _context.FavoriteSong.Remove(favoriteSong);
            _context.SaveChanges();
            return Ok();
        }
    }
}
