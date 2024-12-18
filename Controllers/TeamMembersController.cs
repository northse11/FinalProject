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

        [HttpGet]
        public IActionResult GetMembers()
        {
            return Ok(_context.TeamMember.ToList());
        }

        [HttpGet("{id?}")]
        public IActionResult GetMember(int? id)
        {
            TeamMember member = _context.TeamMember.Find(id);
            if (id == 0 || member == null)
            {
                var results = _context.TeamMember.Take(5).ToList();
                return Ok(results);
            }
            else
            {
                return Ok(member);
            }
        }
        [HttpPost]
        public IActionResult PostTeamMember(TeamMember member)
        {
            _context.TeamMember.Add(member);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteTeamMember(int id)
        {
            TeamMember member = _context.TeamMember.Find(id);
            if (member == null)
            {
                return NotFound();
            }
            else
            {
                try
                {
                    _context.TeamMember.Remove(member);
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
        public IActionResult PutTeamMember(TeamMember member)
        {
            try
            {
                _context.Entry(member).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return NotFound();
            }
        }

        [HttpGet("{id}/favoritesongs")]
        public IActionResult GetMemberFavoriteSongs(int id)
        {
            var favoriteSongs = _context.FavoriteSong
                .Where(fs => fs.TeamMemberID == id)
                .ToList();

            if (!favoriteSongs.Any())
            {
                return NotFound("No favorite songs found for the specified team member.");
            }

            return Ok(favoriteSongs);
        }


    }
}
