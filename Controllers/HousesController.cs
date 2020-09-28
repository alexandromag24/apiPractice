using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using apiPractice.Models;

namespace apiPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HousesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public HousesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Houses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Houses>>> GetHouse()
        {
            return await _context.House.ToListAsync();
        }

        // GET: api/Houses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Houses>> GetHouses(int id)
        {
            var houses = await _context.House.FindAsync(id);

            if (houses == null)
            {
                return NotFound();
            }

            return houses;
        }

        // PUT: api/Houses/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHouses(int id, Houses houses)
        {
            if (id != houses.Id)
            {
                return BadRequest();
            }

            _context.Entry(houses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HousesExists(id))
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

        // POST: api/Houses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Houses>> PostHouses(Houses houses)
        {
            _context.House.Add(houses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHouses", new { id = houses.Id }, houses);
        }

        // DELETE: api/Houses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Houses>> DeleteHouses(int id)
        {
            var houses = await _context.House.FindAsync(id);
            if (houses == null)
            {
                return NotFound();
            }

            _context.House.Remove(houses);
            await _context.SaveChangesAsync();

            return houses;
        }

        private bool HousesExists(int id)
        {
            return _context.House.Any(e => e.Id == id);
        }
    }
}
