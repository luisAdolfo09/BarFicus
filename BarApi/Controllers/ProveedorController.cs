using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoData; // Asegúrate de tener un ProveedorData similar al EmpleadoData
using SharedModels;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class ProveedorController : ControllerBase
    {
        private readonly ProveedorData _proveedorData;

        // Constructor para inyección de dependencia
        public ProveedorController(ProveedorData proveedorData)
        {
            _proveedorData = proveedorData;
        }

        // GET: api/proveedor
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            // Obtiene la lista de proveedores desde la capa de datos
            List<Proveedor> lista = await _proveedorData.Lista();

            // Si la lista está vacía, responde con un código 204 (No Content)
            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            // Si tiene datos, responde con un código 200 (OK)
            return Ok(lista);
        }

        // POST: api/proveedor
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Proveedor objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El proveedor no puede ser nulo");
            }

            // Llama a la capa de datos para crear el proveedor
            bool respuesta = await _proveedorData.Crear(objeto);

            // Si la creación es exitosa, responde con un código 201 (Created) y los detalles
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = objeto.IdProveedor }, objeto);
            }

            // Si la creación falla, responde con un código 500 (Internal Server Error)
            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }

        // PUT: api/proveedor
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Proveedor objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El proveedor no puede ser nulo");
            }

            // Llama a la capa de datos para editar el proveedor
            bool respuesta = await _proveedorData.Editar(objeto);

            // Si la edición es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la edición falla, responde con un código 404 (Not Found) si el proveedor no existe
            return NotFound(new { isSuccess = false, message = "Proveedor no encontrado" });
        }

        // DELETE: api/proveedor/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            // Llama a la capa de datos para eliminar el proveedor
            bool respuesta = await _proveedorData.Eliminar(id);

            // Si la eliminación es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la eliminación falla, responde con un código 404 (Not Found) si el proveedor no existe
            return NotFound(new { isSuccess = false, message = "Proveedor no encontrado" });
        }
    }
}
