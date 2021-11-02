using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiMySql.Data;
using ApiMySql.Data.Entities.SystemUsers;
using ApiMySql.Models;
using ApiMySql.Data.Entities.Positions;

namespace ApiMySql.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SystemUsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public SystemUsersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/SystemUsers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SystemUser>>> GetSystemUsers()
        {
            return await _context.SystemUsers.ToListAsync();
        }

        [HttpGet("/List")]
        public async Task<ActionResult<IEnumerable<SystemUser>>> GetList()
        {
            var result = await _context.SystemUsers.AsNoTracking().AsQueryable().Include(r => r.Position).OrderBy(e => e.Name).ToListAsync();
            return result;
        }

        [HttpPost("/Filter")]
        public async Task<ActionResult<ResponseData<SystemUser>>> Filter(FilterData filter)
            {
            var query =  _context.SystemUsers.AsNoTracking().AsQueryable().Include(r => r.Position).OrderBy(e => e.Name);

            var total = query.Count();

            var skip = (filter.Page - 1) * filter.PageSize;
            var result = query.Skip(skip).Take(filter.PageSize).ToList();

            return new ResponseData<SystemUser>
            {
                Total = total,
                Data = result
            };
        }
        [HttpGet("/Positions")]
        public async Task<ActionResult<IEnumerable<Position>>> GetPositions()
        {
            var result = await _context.Positions.OrderBy(e => e.Name).ToListAsync();
            return result;
        }

        // GET: api/SystemUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SystemUser>> GetSystemUser(Guid id)
        {
            var systemUser = await _context.SystemUsers.FindAsync(id);

            if (systemUser == null)
            {
                return NotFound();
            }

            return systemUser;
        }

        // PUT: api/SystemUsers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSystemUser(Guid id, SystemUser systemUser)
        {
            if (id != systemUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(systemUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemUserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/SystemUsers
        [HttpPost("/Save")]
        public async Task<ActionResult<SystemUser>> PostSystemUser([FromBody] SystemUser systemUser)
        {
            _context.SystemUsers.Add(systemUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSystemUser", new { id = systemUser.Id }, systemUser);
        }

        // DELETE: api/SystemUsers/5
        [HttpDelete("/Delete/{id}")]
        public async Task<IActionResult> DeleteSystemUser(Guid id)
        {
            var systemUser = await _context.SystemUsers.FindAsync(id);
            if (systemUser == null)
            {
                return NotFound();
            }

            _context.SystemUsers.Remove(systemUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SystemUserExists(Guid id)
        {
            return _context.SystemUsers.Any(e => e.Id == id);
        }
    }
}
