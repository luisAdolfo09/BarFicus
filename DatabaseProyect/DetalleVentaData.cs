using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect;  
using SharedModels;     

namespace ProyectoData
{
    public class DetalleVentaData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public DetalleVentaData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Obtener la lista de detalles de venta utilizando un procedimiento almacenado
        public async Task<List<DetalleVenta>> Lista()
        {
            List<DetalleVenta> lista = new List<DetalleVenta>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene los detalles de venta
                    SqlCommand cmd = new SqlCommand("sp_listaDetalleVenta", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new DetalleVenta
                            {
                                IdDetalleVenta = reader.GetInt32(reader.GetOrdinal("IdDetalleVenta")),
                                IdVenta = reader.GetInt32(reader.GetOrdinal("IdVenta")),
                                IdProducto = reader.GetInt32(reader.GetOrdinal("IdProducto")),
                                IdEmpleado = reader.GetInt32(reader.GetOrdinal("IdEmpleado")),
                                Cantidad = reader.GetInt32(reader.GetOrdinal("Cantidad")),
                                PrecioUnitario = reader.GetDecimal(reader.GetOrdinal("PrecioUnitario"))
                            });
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error en la consulta SQL: " + sqlEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return lista;
        }

        // Crear un nuevo detalle de venta utilizando un procedimiento almacenado
        public async Task<bool> Crear(DetalleVenta objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearDetalleVenta", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdVenta", objeto.IdVenta);
                    cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto);
                    cmd.Parameters.AddWithValue("@IdEmpleado", objeto.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", objeto.PrecioUnitario);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear el detalle de venta: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Editar un detalle de venta existente utilizando un procedimiento almacenado
        public async Task<bool> Editar(DetalleVenta objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarDetalleVenta", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdDetalleVenta", objeto.IdDetalleVenta);
                    cmd.Parameters.AddWithValue("@IdVenta", objeto.IdVenta);
                    cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto);
                    cmd.Parameters.AddWithValue("@IdEmpleado", objeto.IdEmpleado);
                    cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", objeto.PrecioUnitario);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar el detalle de venta: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Eliminar un detalle de venta utilizando un procedimiento almacenado
        public async Task<bool> Eliminar(int idDetalleVenta)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarDetalleVenta", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar el parámetro de IdDetalleVenta
                    cmd.Parameters.AddWithValue("@IdDetalleVenta", idDetalleVenta);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar el detalle de venta: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }
    }
}
