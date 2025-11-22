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
            public readonly IUserService _userService;

            public UsuariosController(IUserService usuarioService)
            {
                _userService = usuarioService;
            }

            [Authorize(Roles = "Oficina")]
            [HttpGet]
            public async Task<IActionResult> GetAll()
            {
                var usuarios = await _userService.GetAllAsync();
                return Ok(usuarios);
            }

            [Authorize(Roles = "Oficina")]
            [HttpGet("Activos")]
            public async Task<IActionResult> GetActivos()
            {
                var usuarios = await _userService.GetActivosAsync();
                return Ok(usuarios);
            }

            [Authorize(Roles = "Oficina, Encargado")]
            [HttpGet("{id}")]
            public async Task<IActionResult> GetById(int id)
            {
                var usuario = await _userService.GetByIdAsync(id);
                if (usuario == null) return NotFound();
                return Ok(usuario);
            }

            [Authorize(Roles = "Oficina")]
            [HttpPost]
            public async Task<IActionResult> Create([FromBody] DTOCreateUser dto)
            {
                var usuario = await _userService.CreateAsync(dto);
                return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
            }

            [Authorize(Roles = "Oficina")]
            [HttpPut("{id}")]
            public async Task<IActionResult> Update(int id, [FromBody] DTOCreateUser dto)
            {
                await _userServicer.UpdateAsync(id, dto);
                return NoContent();
            }

            [Authorize(Roles = "Oficina")]
            [HttpDelete("{id}")]
            public async Task<IActionResult> Delete(int id)
            {
                await _userService.DeleteAsync(id);
                return NoContent();
            }
        }
    }
}
