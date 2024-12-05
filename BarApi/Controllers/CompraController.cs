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
    public class CompraController : ControllerBase
    {
        private readonly CompraData _compraData;

        // Constructor para inyección de dependencia
        public CompraController(CompraData compraData)
        {
            _compraData = compraData;
        }

        // GET: api/compra
        [HttpGet]
        public async Task<IActionResult> Lista()
        {
            List<Compra> lista = await _compraData.Lista();

            if (lista == null || lista.Count == 0)
            {
                return NoContent();
            }

            return Ok(lista);
        }

        // POST: api/compra
        [HttpPost]
        public async Task<IActionResult> Crear([FromBody] Compra objeto)
        {
            if (objeto == null)
            {
                return BadRequest("La compra no puede ser nula");
            }

            // Validar IdProveedor antes de pasar a la base de datos
            if (objeto.IdProveedor == null || objeto.IdProveedor <= 0)
            {
                return BadRequest("El IdProveedor es obligatorio y debe ser un valor válido.");
            }

            bool respuesta = await _compraData.Crear(objeto);
            if (respuesta)
            {
                return CreatedAtAction(nameof(Lista), new { id = objeto.IdCompra }, objeto);
            }

            return StatusCode(StatusCodes.Status500InternalServerError, new { isSuccess = respuesta });
        }


        // PUT: api/compra
        [HttpPut]
        public async Task<IActionResult> Editar([FromBody] Compra objeto)
        {
            if (objeto == null)
            {
                return BadRequest("La compra no puede ser nula");
            }

            bool respuesta = await _compraData.Editar(objeto);

            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            return NotFound(new { isSuccess = false, message = "Compra no encontrada" });
        }

        // DELETE: api/compra/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> Eliminar(int id)
        {
            bool respuesta = await _compraData.Eliminar(id);

            if (respuesta)
            {
                return Ok(new { isSuccess = respuesta });
            }

            return NotFound(new { isSuccess = false, message = "Compra no encontrada" });
        }
    }
}
