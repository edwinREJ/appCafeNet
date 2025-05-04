using Microsoft.AspNetCore.Mvc;
using appCafeNet.Data;
using appCafeNet.Models;

namespace appCafeNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfileController : ControllerBase
    {
        private readonly DataProfile _context;

        public ProfileController(DataProfile context)
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterProfile([FromBody] Profile profile)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Profiles.Add(profile);
            await _context.SaveChangesAsync();

            return Ok(new { message = "Perfil registrado exitosamente." });
        }
    }
}



