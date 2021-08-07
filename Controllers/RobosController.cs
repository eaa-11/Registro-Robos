using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RobosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public RobosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Robos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Robo>>> GetRobos()
        {
            return await _context.Robos.ToListAsync();
        }

        // GET: api/Robos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Robo>> GetRobo(int id)
        {
            var robo = await _context.Robos.FindAsync(id);

            if (robo == null)
            {
                return NotFound();
            }

            return robo;
        }

        // PUT: api/Robos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRobo(Robo robo)
        {
            _context.Entry(robo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {

                throw;
            }

            return NoContent();
        }

        // POST: api/Robos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Robo>> PostRobo(Robo robo)
        {
            _context.Robos.Add(robo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRobo", new { id = robo.Id }, robo);
        }

        // DELETE: api/Robos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRobo(int id)
        {
            var robo = await _context.Robos.FindAsync(id);
            if (robo == null)
            {
                return NotFound();
            }

            _context.Robos.Remove(robo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RoboExists(int id)
        {
            return _context.Robos.Any(e => e.Id == id);
        }
    }
}
