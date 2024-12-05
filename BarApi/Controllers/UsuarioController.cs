using DatabaseProyect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels;

namespace BarApi.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioData _usuarioData;

        // Constructor para inyección de dependencia
        public UsuarioController(UsuarioData usuarioData)
        {
            _usuarioData = usuarioData;
        }

        // GET: api/usuario
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            var usuarios = await _usuarioData.Lista();
            if (usuarios == null || usuarios.Count == 0)
            {
                return NoContent();
            }
            return Ok(usuarios);
        }

        // GET: api/usuario/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> ObtenerPorId(int id)
        {
            var usuario = await _usuarioData.ObtenerPorId(id);
            if (usuario == null)
            {
                return NotFound(new { message = "Usuario no encontrado" });
            }
            return Ok(usuario);
        }

        // POST: api/usuario
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Usuarios usuario)
        {
            if (usuario == null)
            {
                return BadRequest("El usuario no puede ser nulo");
            }

            bool respuesta = await _usuarioData.Crear(usuario);
            if (respuesta)
            {
                return CreatedAtAction(nameof(ObtenerPorId), new { id = usuario.Id_Usuario }, usuario);
            }

            return StatusCode(StatusCodes.Status500InternalServerError, new { message = "Error al crear el usuario" });
        }

        // PUT: api/usuario
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Usuarios usuario)
        {
            if (usuario == null)
            {
                return BadRequest("El usuario no puede ser nulo");
            }

            bool respuesta = await _usuarioData.Editar(usuario);
            if (respuesta)
            {
                return Ok(new { message = "Usuario actualizado correctamente" });
            }

            return NotFound(new { message = "Usuario no encontrado" });
        }

        // DELETE: api/usuario/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            bool respuesta = await _usuarioData.Eliminar(id);
            if (respuesta)
            {
                return Ok(new { message = "Usuario eliminado correctamente" });
            }
            return NotFound(new { message = "Usuario no encontrado" });
        }
    }
}


