using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect;  
using SharedModels;     

namespace ProyectoData
{
    public class VentaData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public VentaData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Obtener la lista de ventas usando un procedimiento almacenado
        public async Task<List<Venta>> Lista()
        {
            List<Venta> lista = new List<Venta>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene las ventas
                    SqlCommand cmd = new SqlCommand("sp_listaVentas", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new Venta
                            {
                                IdVenta = reader.GetInt32(reader.GetOrdinal("IdVenta")),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                                IdCliente = reader.IsDBNull(reader.GetOrdinal("IdCliente"))
                                           ? (int?)null
                                           : reader.GetInt32(reader.GetOrdinal("IdCliente")),
                                Total = reader.GetDecimal(reader.GetOrdinal("Total")),
                                Descripcion = reader["Descripcion"].ToString()
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

        // Crear una nueva venta utilizando un procedimiento almacenado
        public async Task<bool> Crear(Venta objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearVenta", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Fecha", objeto.Fecha);
                    cmd.Parameters.AddWithValue("@IdCliente", objeto.IdCliente ?? (object)DBNull.Value); // Soporta valores nulos
                    cmd.Parameters.AddWithValue("@Total", objeto.Total);
                    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear la venta: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Editar una venta existente utilizando un procedimiento almacenado
        public async Task<bool> Editar(Venta objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarVenta", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdVenta", objeto.IdVenta);
                    cmd.Parameters.AddWithValue("@Fecha", objeto.Fecha);
                    cmd.Parameters.AddWithValue("@IdCliente", objeto.IdCliente ?? (object)DBNull.Value); // Soporta valores nulos
                    cmd.Parameters.AddWithValue("@Total", objeto.Total);
                    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar la venta: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Eliminar una venta utilizando un procedimiento almacenado
        public async Task<bool> Eliminar(int id)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarVenta", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar el parámetro de IdVenta
                    cmd.Parameters.AddWithValue("@IdVenta", id);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar la venta: " + sqlEx.Message);
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
