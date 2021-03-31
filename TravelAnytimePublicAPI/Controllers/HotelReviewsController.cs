using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelAnytimePublicAPI.DAL;
using TravelAnytimePublicAPI.Models;

namespace TravelAnytimePublicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelReviewsController : ControllerBase
    {
        private readonly DataContext _context;

        public HotelReviewsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/HotelReviews
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelReview>>> GetHotelReviews()
        {
            return await _context.HotelReviews.Include(x => x.hotel).ToListAsync();
        }

        // GET: api/HotelReviews/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HotelReview>> GetHotelReview(int id)
        {
            var hotelReview = await _context.HotelReviews.FindAsync(id);

            if (hotelReview == null)
            {
                return NotFound();
            }

            return hotelReview;
        }

        // PUT: api/HotelReviews/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHotelReview(int id, HotelReview hotelReview)
        {
            if (id != hotelReview.id)
            {
                return BadRequest();
            }

            _context.Entry(hotelReview).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HotelReviewExists(id))
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

        // POST: api/HotelReviews
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<HotelReview>> PostHotelReview(HotelReview hotelReview)
        {
            _context.HotelReviews.Add(hotelReview);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHotelReview", new { id = hotelReview.id }, hotelReview);
        }

        // DELETE: api/HotelReviews/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<HotelReview>> DeleteHotelReview(int id)
        {
            var hotelReview = await _context.HotelReviews.FindAsync(id);
            if (hotelReview == null)
            {
                return NotFound();
            }

            _context.HotelReviews.Remove(hotelReview);
            await _context.SaveChangesAsync();

            return hotelReview;
        }

        private bool HotelReviewExists(int id)
        {
            return _context.HotelReviews.Any(e => e.id == id);
        }
    }
}
