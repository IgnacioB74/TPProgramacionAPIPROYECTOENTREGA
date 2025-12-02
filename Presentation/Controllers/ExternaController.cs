using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExternaController : ControllerBase
    {
        private readonly IApiExterna _service;

        public ExternaController(IApiExterna service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetExternal()
        {
            var data = await _service.GetExternalDataAsync();
            return Ok(data);
        }
    }

}


