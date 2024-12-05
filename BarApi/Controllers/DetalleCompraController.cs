using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoData; // Asegúrate de tener un DetalleCompraData similar al ProductoData o IngredienteData
using SharedModels;

namespace ProyectoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class DetalleCompraController : ControllerBase
    {
        private readonly DetalleCompraData _detalleCompraData;

        // Constructor para inyección de dependencia
        public DetalleCompraController(DetalleCompraData detalleCompraData)
        {
            _detalleCompraData = detalleCompraData;
        }

        // GET: api/detallecompra
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            // Obtiene la lista de detalles de compra desde la capa de datos
            List<DetalleCompra> lista = await _detalleCompraData.Lista();

            // Si la lista está vacía, responde con un código 204 (No Content)
            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            // Si tiene datos, responde con un código 200 (OK)
            return Ok(lista);
        }

        // POST: api/detallecompra
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] DetalleCompra objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El detalle de compra no puede ser nulo");
            }

            // Llama a la capa de datos para crear el detalle de compra
            bool respuesta = await _detalleCompraData.Crear(objeto);

            // Si la creación es exitosa, responde con un código 201 (Created) y los detalles
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = objeto.IdDetalleCompra }, objeto);
            }

            // Si la creación falla, responde con un código 500 (Internal Server Error)
            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }

        // PUT: api/detallecompra
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] DetalleCompra objeto)
        {
            // Valida que el objeto no sea nulo
            if (objeto == null)
            {
                return BadRequest("El detalle de compra no puede ser nulo");
            }

            // Llama a la capa de datos para editar el detalle de compra
            bool respuesta = await _detalleCompraData.Editar(objeto);

            // Si la edición es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la edición falla, responde con un código 404 (Not Found) si el detalle de compra no existe
            return NotFound(new { isSuccess = false, message = "Detalle de compra no encontrado" });
        }

        // DELETE: api/detallecompra/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            // Llama a la capa de datos para eliminar el detalle de compra
            bool respuesta = await _detalleCompraData.Eliminar(id);

            // Si la eliminación es exitosa, responde con un código 200 (OK)
            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            // Si la eliminación falla, responde con un código 404 (Not Found) si el detalle de compra no existe
            return NotFound(new { isSuccess = false, message = "Detalle de compra no encontrado" });
        }
    }
}
