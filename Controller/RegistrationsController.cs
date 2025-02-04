using Microsoft.AspNetCore.Mvc;
using TrowulanForm.Models;
using TrowulanForm.Data;

namespace TrowulanForm.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RegistrationsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Registration registration)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.Registrations.AddAsync(registration);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "Registration saved successfully!" });
        }
    }
}
