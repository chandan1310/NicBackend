using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NicBackend.Data;
using NicBackend.Models;

namespace NicBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceRequestController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ServiceRequestController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ServiceRequest>>> GetAll()
        {
            return Ok(await _context.ServiceRequests.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceRequest>> Get(int id)
        {
            var request = await _context.ServiceRequests.FindAsync(id);
            if (request == null) return NotFound();
            return Ok(request);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceRequest>> Create(ServiceRequest request)
        {
            request.CreatedDate = DateTime.Now;
            _context.ServiceRequests.Add(request);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = request.Id }, request);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ServiceRequest request)
        {
            if (id != request.Id) return BadRequest();
            _context.Entry(request).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var request = await _context.ServiceRequests.FindAsync(id);
            if (request == null) return NotFound();
            _context.ServiceRequests.Remove(request);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
