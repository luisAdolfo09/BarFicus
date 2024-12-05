using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect;  
using SharedModels;     

namespace ProyectoData
{
    public class DetalleCompraData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public DetalleCompraData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Obtener la lista de detalles de compra utilizando un procedimiento almacenado
        public async Task<List<DetalleCompra>> Lista()
        {
            List<DetalleCompra> lista = new List<DetalleCompra>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene los detalles de compra
                    SqlCommand cmd = new SqlCommand("sp_listaDetalleCompra", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new DetalleCompra
                            {
                                IdDetalleCompra = reader.GetInt32(reader.GetOrdinal("IdDetalleCompra")),
                                IdCompra = reader.GetInt32(reader.GetOrdinal("IdCompra")),
                                IdProducto = reader.GetInt32(reader.GetOrdinal("IdProducto")),
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

        // Crear un nuevo detalle de compra utilizando un procedimiento almacenado
        public async Task<bool> Crear(DetalleCompra objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearDetalleCompra", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdCompra", objeto.IdCompra);
                    cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", objeto.PrecioUnitario);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear el detalle de compra: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Editar un detalle de compra existente utilizando un procedimiento almacenado
        public async Task<bool> Editar(DetalleCompra objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarDetalleCompra", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdDetalleCompra", objeto.IdDetalleCompra);
                    cmd.Parameters.AddWithValue("@IdCompra", objeto.IdCompra);
                    cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto);
                    cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                    cmd.Parameters.AddWithValue("@PrecioUnitario", objeto.PrecioUnitario);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar el detalle de compra: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Eliminar un detalle de compra utilizando un procedimiento almacenado
        public async Task<bool> Eliminar(int idDetalleCompra)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarDetalleCompra", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar el parámetro de IdDetalleCompra
                    cmd.Parameters.AddWithValue("@IdDetalleCompra", idDetalleCompra);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar el detalle de compra: " + sqlEx.Message);
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
