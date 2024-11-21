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

        // GET: api/Hobbies/5
        [HttpGet("{id}")]
        public IActionResult GetHobbies(int id)
        {
            Hobby hobby = _context.Hobby.Find(id);
            if (hobby == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(hobby);
            }

        }
    }
}
