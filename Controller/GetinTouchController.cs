using Microsoft.AspNetCore.Mvc;
using TrowulanForm.Models;
using TrowulanForm.Data;

namespace TrowulanForm.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class GetinTouchController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GetinTouchController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] GetinTouch GetinTouch)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _context.GetinTouch.AddAsync(GetinTouch);
            await _context.SaveChangesAsync();

            return Ok(new { Message = "GetinTouch saved successfully!" });
        }
    }
}