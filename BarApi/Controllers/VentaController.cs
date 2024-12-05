using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoData; // Asegúrate de tener un VentaData similar al ProveedorData o ProductoData
using SharedModels;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        private readonly VentaData _ventaData;

        // Constructor para inyección de dependencia
        public VentaController(VentaData ventaData)
        {
            _ventaData = ventaData;
        }

        // GET: api/venta
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            // Obtiene la lista de ventas desde la capa de datos
            List<Venta> lista = await _ventaData.Lista();

            // Si la lista está vacía, responde con un código 204 (No Content)
            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            // Si tiene datos, responde con un código 200 (OK)
            return Ok(lista);
        }

        // POST: api/venta
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Venta objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("La venta no puede ser nula");
            }

            // Llama a la capa de datos para crear la venta
            bool respuesta = await _ventaData.Crear(objeto);

            // Si la creación es exitosa, responde con un código 201 (Created) y los detalles
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = objeto.IdVenta }, objeto);
            }

            // Si la creación falla, responde con un código 500 (Internal Server Error)
            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }

        // PUT: api/venta
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Venta objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("La venta no puede ser nula");
            }

            // Llama a la capa de datos para editar la venta
            bool respuesta = await _ventaData.Editar(objeto);

            // Si la edición es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la edición falla, responde con un código 404 (Not Found) si la venta no existe
            return NotFound(new { isSuccess = false, message = "Venta no encontrada" });
        }

        // DELETE: api/venta/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            // Llama a la capa de datos para eliminar la venta
            bool respuesta = await _ventaData.Eliminar(id);

            // Si la eliminación es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la eliminación falla, responde con un código 404 (Not Found) si la venta no existe
            return NotFound(new { isSuccess = false, message = "Venta no encontrada" });
        }
    }
}
