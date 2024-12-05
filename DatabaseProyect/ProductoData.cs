using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect;  
using SharedModels;     

namespace ProyectoData
{
    public class ProductoData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public ProductoData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Obtener la lista de productos usando un procedimiento almacenado
        public async Task<List<Producto>> Lista()
        {
            List<Producto> lista = new List<Producto>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene los productos
                    SqlCommand cmd = new SqlCommand("sp_listaProductos", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new Producto
                            {
                                IdProducto = reader.GetInt32(reader.GetOrdinal("IdProducto")),
                                Nombre = reader["Nombre"].ToString(),
                                Tipo = reader["Tipo"].ToString(),
                                Marca = reader["Marca"].ToString(),
                                Precio = reader.GetDecimal(reader.GetOrdinal("Precio")),
                                CantidadDisponible = reader.GetInt32(reader.GetOrdinal("CantidadDisponible")),
                                Descripcion = reader["Descripcion"].ToString(),
                                FechaCaducidad = reader.IsDBNull(reader.GetOrdinal("FechaCaducidad"))
                                                 ? (DateTime?)null
                                                 : reader.GetDateTime(reader.GetOrdinal("FechaCaducidad"))
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

        // Crear un nuevo producto utilizando un procedimiento almacenado
        public async Task<bool> Crear(Producto objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearProducto", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@Tipo", objeto.Tipo);
                    cmd.Parameters.AddWithValue("@Marca", objeto.Marca);
                    cmd.Parameters.AddWithValue("@Precio", objeto.Precio);
                    cmd.Parameters.AddWithValue("@CantidadDisponible", objeto.CantidadDisponible);
                    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaCaducidad", objeto.FechaCaducidad ?? (object)DBNull.Value);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear el producto: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Editar un producto existente utilizando un procedimiento almacenado
        public async Task<bool> Editar(Producto objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarProducto", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto);
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@Tipo", objeto.Tipo);
                    cmd.Parameters.AddWithValue("@Marca", objeto.Marca);
                    cmd.Parameters.AddWithValue("@Precio", objeto.Precio);
                    cmd.Parameters.AddWithValue("@CantidadDisponible", objeto.CantidadDisponible);
                    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaCaducidad", objeto.FechaCaducidad ?? (object)DBNull.Value);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar el producto: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Eliminar un producto utilizando un procedimiento almacenado
        public async Task<bool> Eliminar(int id)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarProducto", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar el parámetro de IdProducto
                    cmd.Parameters.AddWithValue("@IdProducto", id);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar el producto: " + sqlEx.Message);
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
