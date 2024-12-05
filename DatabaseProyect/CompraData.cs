using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect; 
using SharedModels;   

namespace ProyectoData
{
    public class CompraData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public CompraData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Obtener la lista de compras usando un procedimiento almacenado
        public async Task<List<Compra>> Lista()
        {
            List<Compra> lista = new List<Compra>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync(); // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene las compras
                    SqlCommand cmd = new SqlCommand("sp_listaCompras", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new Compra
                            {
                                IdCompra = reader.GetInt32(reader.GetOrdinal("Id_compra")),
                                Fecha = reader.GetDateTime(reader.GetOrdinal("Fecha")),
                                IdProveedor = reader.IsDBNull(reader.GetOrdinal("Id_proveedor")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("IdProveedor")),
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

        // Crear una nueva compra utilizando un procedimiento almacenado
        public async Task<bool> Crear(Compra objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearCompra", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Fecha", objeto.Fecha);
                    cmd.Parameters.AddWithValue("@IdProveedor", (object)objeto.IdProveedor ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Total", objeto.Total);
                    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);

                    await conexion.OpenAsync(); // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear la compra: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Editar una compra existente utilizando un procedimiento almacenado
        public async Task<bool> Editar(Compra objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarCompra", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdCompra", objeto.IdCompra);
                    cmd.Parameters.AddWithValue("@Fecha", objeto.Fecha);
                    cmd.Parameters.AddWithValue("@IdProveedor", (object)objeto.IdProveedor ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Total", objeto.Total);
                    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);

                    await conexion.OpenAsync(); // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar la compra: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Eliminar una compra utilizando un procedimiento almacenado
        public async Task<bool> Eliminar(int id)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarCompra", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar el parámetro de IdCompra
                    cmd.Parameters.AddWithValue("@IdCompra", id);

                    await conexion.OpenAsync(); // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar la compra: " + sqlEx.Message);
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
