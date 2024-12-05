using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoData;
using SharedModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteData _clienteData;

        // Constructor para inyección de dependencia
        public ClienteController(ClienteData clienteData)
        {
            _clienteData = clienteData;
        }

        // GET: api/cliente
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            List<Cliente> lista = await _clienteData.Lista();

            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            return Ok(lista);
        }

        // POST: api/cliente
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest("El cliente no puede ser nulo");
            }

            // Validaciones para el cliente
            if (string.IsNullOrEmpty(cliente.Nombre))
            {
                return BadRequest("El nombre es obligatorio.");
            }

            if (string.IsNullOrEmpty(cliente.Email))
            {
                return BadRequest("El correo electrónico es obligatorio.");
            }

            if (cliente.Telefono <= 0)
            {
                return BadRequest("El teléfono debe ser un valor válido.");
            }

            bool respuesta = await _clienteData.Crear(cliente);
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = cliente.Email }, cliente);  // Usando Email como identificador único
            }

            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }

        // PUT: api/cliente
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest("El cliente no puede ser nulo");
            }

            bool respuesta = await _clienteData.Editar(cliente);

            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            return NotFound(new { isSuccess = false, message = "Cliente no encontrado" });
        }

        // DELETE: api/cliente/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(string id)
        {
            bool respuesta = await _clienteData.Eliminar(id);  // Suponiendo que el identificador es Email

            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            return NotFound(new { isSuccess = false, message = "Cliente no encontrado" });
        }
    }
}
