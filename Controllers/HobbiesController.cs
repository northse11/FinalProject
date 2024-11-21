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
    public class HobbiesController : ControllerBase
    {
        private readonly FinalProjectContext _context;

        public HobbiesController(FinalProjectContext context)
        {
            _context = context;
        }

        // GET: api/Hobbies
        [HttpGet]
        public IActionResult GetHobbies()
        {
            return Ok(_context.Hobby.ToList());
        }

        //COMMIT THIS ON THURSDAY
        [HttpGet("{id?}")]
        public IActionResult GetHobbies(int? id)
        {
            Hobby hobby = _context.Hobby.Find(id);
            if ( hobby == null || id == 0)// If id is either a 0 or is null
            {
                // Return the first five results
                var firstFiveHobbies = _context.Hobby
                    .Take(5)
                    .ToList();
                return Ok(firstFiveHobbies);

            }
            else
            {

                return Ok(hobby);
                
            }
        }
        [HttpPost]
        public IActionResult PostHobbies(Hobby hobby)
        {
            _context.Hobby.Add(hobby);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteHobby(int id)
        {
            Hobby hobby = _context.Hobby.Find(id);
            if (hobby == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    _context.Hobby.Remove(hobby);
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
        public IActionResult PutHobby (Hobby hobby)
        {
            try
            {
                _context.Entry(hobby).State = EntityState.Modified;
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
