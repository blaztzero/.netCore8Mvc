using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcEntity.Models;

namespace MvcEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitasEnfermeriumsController : ControllerBase
    {
        private readonly Context _context;

        public VisitasEnfermeriumsController(Context context)
        {
            _context = context;
        }

        // GET: api/VisitasEnfermeriums
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VisitasEnfermerium>>> GetVisitasEnfermeria()
        {
            return await _context.VisitasEnfermeria.ToListAsync();
        }

        // GET: api/VisitasEnfermeriums/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VisitasEnfermerium>> GetVisitasEnfermerium(decimal id)
        {
            var visitasEnfermerium = await _context.VisitasEnfermeria.FindAsync(id);

            if (visitasEnfermerium == null)
            {
                return NotFound();
            }

            return visitasEnfermerium;
        }

        // PUT: api/VisitasEnfermeriums/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVisitasEnfermerium(decimal id, VisitasEnfermerium visitasEnfermerium)
        {
            if (id != visitasEnfermerium.IdVisita)
            {
                return BadRequest();
            }

            _context.Entry(visitasEnfermerium).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VisitasEnfermeriumExists(id))
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

        // POST: api/VisitasEnfermeriums
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VisitasEnfermerium>> PostVisitasEnfermerium(VisitasEnfermerium visitasEnfermerium)
        {
            _context.VisitasEnfermeria.Add(visitasEnfermerium);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVisitasEnfermerium", new { id = visitasEnfermerium.IdVisita }, visitasEnfermerium);
        }

        // DELETE: api/VisitasEnfermeriums/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVisitasEnfermerium(decimal id)
        {
            var visitasEnfermerium = await _context.VisitasEnfermeria.FindAsync(id);
            if (visitasEnfermerium == null)
            {
                return NotFound();
            }

            _context.VisitasEnfermeria.Remove(visitasEnfermerium);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VisitasEnfermeriumExists(decimal id)
        {
            return _context.VisitasEnfermeria.Any(e => e.IdVisita == id);
        }
    }
}
