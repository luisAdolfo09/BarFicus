using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoData; // Asegúrate de tener un DetalleVentaData similar al ProductoData o IngredienteData
using SharedModels;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class DetalleVentaController : ControllerBase
    {
        private readonly DetalleVentaData _detalleVentaData;

        // Constructor para inyección de dependencia
        public DetalleVentaController(DetalleVentaData detalleVentaData)
        {
            _detalleVentaData = detalleVentaData;
        }

        // GET: api/detalleventa
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            // Obtiene la lista de detalles de venta desde la capa de datos
            List<DetalleVenta> lista = await _detalleVentaData.Lista();

            // Si la lista está vacía, responde con un código 204 (No Content)
            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            // Si tiene datos, responde con un código 200 (OK)
            return Ok(lista);
        }

        // POST: api/detalleventa
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] DetalleVenta objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El detalle de venta no puede ser nulo");
            }

            // Llama a la capa de datos para crear el detalle de venta
            bool respuesta = await _detalleVentaData.Crear(objeto);

            // Si la creación es exitosa, responde con un código 201 (Created) y los detalles
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = objeto.IdDetalleVenta }, objeto);
            }

            // Si la creación falla, responde con un código 500 (Internal Server Error)
            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }

        // PUT: api/detalleventa
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] DetalleVenta objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El detalle de venta no puede ser nulo");
            }

            // Llama a la capa de datos para editar el detalle de venta
            bool respuesta = await _detalleVentaData.Editar(objeto);

            // Si la edición es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la edición falla, responde con un código 404 (Not Found) si el detalle de venta no existe
            return NotFound(new { isSuccess = false, message = "Detalle de venta no encontrado" });
        }

        // DELETE: api/detalleventa/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            // Llama a la capa de datos para eliminar el detalle de venta
            bool respuesta = await _detalleVentaData.Eliminar(id);

            // Si la eliminación es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la eliminación falla, responde con un código 404 (Not Found) si el detalle de venta no existe
            return NotFound(new { isSuccess = false, message = "Detalle de venta no encontrado" });
        }
    }
}
