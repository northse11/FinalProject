﻿using System;
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
    public class TeamMembersController : ControllerBase
    {
        private readonly FinalProjectContext _context;

        public TeamMembersController(FinalProjectContext context)
        {
            _context = context;
        }

        //// GET: api/TeamMembers
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<TeamMember>>> GetTeamMember()
        //{
        //    return await _context.TeamMember.ToListAsync();
        //}

        //// GET: api/TeamMembers/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<TeamMember>> GetTeamMember(int id)
        //{
        //    var teamMember = await _context.TeamMember.FindAsync(id);

        //    if (teamMember == null)
        //    {
        //        return NotFound();
        //    }

        //    return teamMember;
        //}

        //// PUT: api/TeamMembers/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutTeamMember(int id, TeamMember teamMember)
        //{
        //    if (id != teamMember.ID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(teamMember).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!TeamMemberExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/TeamMembers
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<TeamMember>> PostTeamMember(TeamMember teamMember)
        //{
        //    _context.TeamMember.Add(teamMember);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetTeamMember", new { id = teamMember.ID }, teamMember);
        //}

        //// DELETE: api/TeamMembers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteTeamMember(int id)
        //{
        //    var teamMember = await _context.TeamMember.FindAsync(id);
        //    if (teamMember == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.TeamMember.Remove(teamMember);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool TeamMemberExists(int id)
        //{
        //    return _context.TeamMember.Any(e => e.ID == id);
        //}
    }
}
