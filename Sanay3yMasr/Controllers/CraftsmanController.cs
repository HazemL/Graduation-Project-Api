using BusinessLogic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Sanay3yMasr.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CraftsmanController : ControllerBase
    {
        private readonly ICraftsmanProfileService _profileService;

        public CraftsmanController(ICraftsmanProfileService profileService)
        {
            _profileService = profileService;
        }

        [HttpGet("profile/{id}")]
        public async Task<IActionResult> GetProfile(int id)
        {
            var result = await _profileService.GetProfileAsync(id);

            if (result == null)
                return NotFound(new { Message = "Craftsman not found" });

            return Ok(result);
        }
    }
}
