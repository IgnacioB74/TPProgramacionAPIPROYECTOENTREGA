using Application.Interfaces;
using Application.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Presentation.Controllers
{
    public class UserController
    {
        [ApiController]
        [Route("api/[controller]")]
        public class UsuariosController : ControllerBase
        {
            private readonly IUserService _service;

            public UsuariosController(IUserService service)
            {
                _service = service;
            }

            [HttpGet]
            public async Task<IActionResult> GetAll()
                => Ok(await _service.GetAllAsync());

            [HttpGet("{id}")]
            public async Task<IActionResult> GetById(int id)
            {
                var result = await _service.GetByIdAsync(id);
                return result == null ? NotFound() : Ok(result);
            }

            [HttpPost]
            public async Task<IActionResult> Create(DTOCreateUser dto)
            {
                var nuevo = await _service.CreateAsync(dto);
                return CreatedAtAction(nameof(GetById), new { id = nuevo.Id }, nuevo);
            }

            [HttpPut("{id}")]
            public async Task<IActionResult> Update(int id, DTOUpdateUser dto)
            {
                var updated = await _service.UpdateAsync(id, dto);
                return updated ? NoContent() : NotFound();
            }

            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                var deleted = await _service.DeleteAsync(id);
                return deleted ? NoContent() : NotFound();
            }
        }

    }
}


