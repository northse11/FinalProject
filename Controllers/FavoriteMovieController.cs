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
    public class FavoriteMoviesController : ControllerBase
    {
        private readonly FinalProjectContext _context;

        public FavoriteMoviesController(FinalProjectContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMovies()
        {
            return Ok(_context.FavoriteMovie.ToList());
        }

        [HttpGet("{id?}")]
        public IActionResult GetMovie(int? id)
        {
            FavoriteMovie movie = _context.FavoriteMovie.Find(id);
            if (id == 0 || movie == null)
            {
                var results = _context.FavoriteMovie.Take(5).ToList();
                return Ok(results);
            }
            else
            {
                return Ok(movie);
            }
        }

        [HttpPost]
        public IActionResult PostFavoriteMovie(FavoriteMovie movie)
        {
            _context.FavoriteMovie.Add(movie);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFavoriteMovie(int id)
        {
            FavoriteMovie movie = _context.FavoriteMovie.Find(id);
            if (movie == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    _context.FavoriteMovie.Remove(movie);
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    return NotFound();
                }
                return Ok();
            }
        }

        [HttpPut]
        public IActionResult PutFavoriteMovie(FavoriteMovie movie)
        {
            try
            {
                _context.Entry(movie).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }
    }
}
