using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoData; // Asegúrate de tener un IngredienteData similar al ProveedorData o ProductoData
using SharedModels;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private readonly IngredienteData _ingredienteData;

        // Constructor para inyección de dependencia
        public IngredienteController(IngredienteData ingredienteData)
        {
            _ingredienteData = ingredienteData;
        }

        // GET: api/ingrediente
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            // Obtiene la lista de ingredientes desde la capa de datos
            List<Ingrediente> lista = await _ingredienteData.Lista();

            // Si la lista está vacía, responde con un código 204 (No Content)
            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            // Si tiene datos, responde con un código 200 (OK)
            return Ok(lista);
        }

        // POST: api/ingrediente
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Ingrediente objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El ingrediente no puede ser nulo");
            }

            // Llama a la capa de datos para crear el ingrediente
            bool respuesta = await _ingredienteData.Crear(objeto);

            // Si la creación es exitosa, responde con un código 201 (Created) y los detalles
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = objeto.IdIngrediente }, objeto);
            }

            // Si la creación falla, responde con un código 500 (Internal Server Error)
            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }

        // PUT: api/ingrediente
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Ingrediente objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El ingrediente no puede ser nulo");
            }

            // Llama a la capa de datos para editar el ingrediente
            bool respuesta = await _ingredienteData.Editar(objeto);

            // Si la edición es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la edición falla, responde con un código 404 (Not Found) si el ingrediente no existe
            return NotFound(new { isSuccess = false, message = "Ingrediente no encontrado" });
        }

        // DELETE: api/ingrediente/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            // Llama a la capa de datos para eliminar el ingrediente
            bool respuesta = await _ingredienteData.Eliminar(id);

            // Si la eliminación es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la eliminación falla, responde con un código 404 (Not Found) si el ingrediente no existe
            return NotFound(new { isSuccess = false, message = "Ingrediente no encontrado" });
        }
    }
}
