using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect;  
using SharedModels;     

namespace ProyectoData
{
    public class IngredienteData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public IngredienteData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Obtener la lista de ingredientes usando un procedimiento almacenado
        public async Task<List<Ingrediente>> Lista()
        {
            List<Ingrediente> lista = new List<Ingrediente>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene los ingredientes
                    SqlCommand cmd = new SqlCommand("sp_listaIngredientes", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new Ingrediente
                            {
                                IdIngrediente = reader.GetInt32(reader.GetOrdinal("IdIngrediente")),
                                Nombre = reader["Nombre"].ToString(),
                                CostoUnitario = reader.GetDecimal(reader.GetOrdinal("CostoUnitario")),
                                CantidadDisponible = reader.GetInt32(reader.GetOrdinal("CantidadDisponible")),
                                Descripcion = reader["Descripcion"].ToString(),
                                FechaCaducidad = reader.IsDBNull(reader.GetOrdinal("FechaCaducidad"))
                                                 ? (DateTime?)null
                                                 : reader.GetDateTime(reader.GetOrdinal("FechaCaducidad")),
                                IdProducto = reader.IsDBNull(reader.GetOrdinal("IdProducto"))
                                            ? (int?)null
                                            : reader.GetInt32(reader.GetOrdinal("IdProducto"))
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

        // Crear un nuevo ingrediente utilizando un procedimiento almacenado
        public async Task<bool> Crear(Ingrediente objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearIngrediente", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@CostoUnitario", objeto.CostoUnitario);
                    cmd.Parameters.AddWithValue("@CantidadDisponible", objeto.CantidadDisponible);
                    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaCaducidad", objeto.FechaCaducidad ?? (object)DBNull.Value); // Soporta valores nulos
                    cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto ?? (object)DBNull.Value); // Soporta valores nulos

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear el ingrediente: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Editar un ingrediente existente utilizando un procedimiento almacenado
        public async Task<bool> Editar(Ingrediente objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarIngrediente", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdIngrediente", objeto.IdIngrediente);
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@CostoUnitario", objeto.CostoUnitario);
                    cmd.Parameters.AddWithValue("@CantidadDisponible", objeto.CantidadDisponible);
                    cmd.Parameters.AddWithValue("@Descripcion", objeto.Descripcion);
                    cmd.Parameters.AddWithValue("@FechaCaducidad", objeto.FechaCaducidad ?? (object)DBNull.Value); // Soporta valores nulos
                    cmd.Parameters.AddWithValue("@IdProducto", objeto.IdProducto ?? (object)DBNull.Value); // Soporta valores nulos

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar el ingrediente: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Eliminar un ingrediente utilizando un procedimiento almacenado
        public async Task<bool> Eliminar(int id)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarIngrediente", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar el parámetro de IdIngrediente
                    cmd.Parameters.AddWithValue("@IdIngrediente", id);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar el ingrediente: " + sqlEx.Message);
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
