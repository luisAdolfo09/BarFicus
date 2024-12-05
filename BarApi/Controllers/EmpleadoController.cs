using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoData;
using SharedModels;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly EmpleadoData _empleadoData;

        // Constructor para inyección de dependencia
        public EmpleadoController(EmpleadoData empleadoData)
        {
            _empleadoData = empleadoData;
        }

        // GET: api/empleado
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            // Obtiene la lista de empleados desde la capa de datos
            List<Empleados> lista = await _empleadoData.Lista();

            // Si la lista está vacía, responde con un código 204 (No Content)
            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            // Si tiene datos, responde con un código 200 (OK)
            return Ok(lista);
        }

        // POST: api/empleado
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Empleados objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El empleado no puede ser nulo");
            }

            // Llama a la capa de datos para crear el empleado
            bool respuesta = await _empleadoData.Crear(objeto);

            // Si la creación es exitosa, responde con un código 201 (Created) y los detalles
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = objeto.IdEmpleado }, objeto);
            }

            // Si la creación falla, responde con un código 500 (Internal Server Error)
            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }

        // PUT: api/empleado
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Empleados objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El empleado no puede ser nulo");
            }

            // Llama a la capa de datos para editar el empleado
            bool respuesta = await _empleadoData.Editar(objeto);

            // Si la edición es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la edición falla, responde con un código 404 (Not Found) si el empleado no existe
            return NotFound(new { isSuccess = false, message = "Empleado no encontrado" });
        }

        // DELETE: api/empleado/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            // Llama a la capa de datos para eliminar el empleado
            bool respuesta = await _empleadoData.Eliminar(id);

            // Si la eliminación es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la eliminación falla, responde con un código 404 (Not Found) si el empleado no existe
            return NotFound(new { isSuccess = false, message = "Empleado no encontrado" });
        }
    }
}