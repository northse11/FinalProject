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
    public class BreakfastItemsController : ControllerBase
    {
        private readonly FinalProjectContext _context;

        public BreakfastItemsController(FinalProjectContext context)
        {
            _context = context;
        }

        // GET: api/BreakfastItems
        [HttpGet]
        public IActionResult GetBreakfastItems()
        {
            return Ok(_context.BreakfastItems.ToList());
        }


        [HttpGet("{id?}")]
        public IActionResult GetBreakfastItems(int? id)
        {
            BreakfastItems breakfast = _context.BreakfastItems.Find(id);
            if (breakfast == null || id == 0)// If id is either a 0 or if id doesn't exists in the database
            {
                // Return the first five results
                var firstFiveBreakfastItems = _context.BreakfastItems
                    .Take(5)
                    .ToList();
                return Ok(firstFiveBreakfastItems);

            }
            else
            {

                return Ok(breakfast);

            }
        }
        [HttpPost]
        public IActionResult PostBreakfastItems(BreakfastItems breakfast)
        {
            _context.BreakfastItems.Add(breakfast);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBreakfastItems(int id)
        {
            BreakfastItems breakfast = _context.BreakfastItems.Find(id);
            if (breakfast == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    _context.BreakfastItems.Remove(breakfast);
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
        public IActionResult PutBreakfastItems(BreakfastItems breakfast)
        {
            try
            {
                _context.Entry(breakfast).State = EntityState.Modified;
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
