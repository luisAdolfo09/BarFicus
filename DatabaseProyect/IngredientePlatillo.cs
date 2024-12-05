using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect; 
using SharedModels;     

namespace ProyectoData
{
    public class IngredientePlatilloData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public IngredientePlatilloData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Obtener la lista de ingredientes por platillo usando un procedimiento almacenado
        public async Task<List<IngredientePlatillo>> Lista()
        {
            List<IngredientePlatillo> lista = new List<IngredientePlatillo>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene los ingredientes por platillo
                    SqlCommand cmd = new SqlCommand("sp_listaIngredientePlatillo", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new IngredientePlatillo
                            {
                                IdPlatillo = reader.GetInt32(reader.GetOrdinal("IdPlatillo")),
                                IdIngrediente = reader.GetInt32(reader.GetOrdinal("IdIngrediente")),
                                CantidadNecesaria = reader.GetInt32(reader.GetOrdinal("CantidadNecesaria"))
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

        // Crear una nueva relación IngredientePlatillo utilizando un procedimiento almacenado
        public async Task<bool> Crear(IngredientePlatillo objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearIngredientePlatillo", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdPlatillo", objeto.IdPlatillo);
                    cmd.Parameters.AddWithValue("@IdIngrediente", objeto.IdIngrediente);
                    cmd.Parameters.AddWithValue("@CantidadNecesaria", objeto.CantidadNecesaria);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear la relación IngredientePlatillo: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Editar una relación IngredientePlatillo existente utilizando un procedimiento almacenado
        public async Task<bool> Editar(IngredientePlatillo objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarIngredientePlatillo", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdPlatillo", objeto.IdPlatillo);
                    cmd.Parameters.AddWithValue("@IdIngrediente", objeto.IdIngrediente);
                    cmd.Parameters.AddWithValue("@CantidadNecesaria", objeto.CantidadNecesaria);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar la relación IngredientePlatillo: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Eliminar una relación IngredientePlatillo utilizando un procedimiento almacenado
        public async Task<bool> Eliminar(int idPlatillo, int idIngrediente)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarIngredientePlatillo", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros de IdPlatillo e IdIngrediente
                    cmd.Parameters.AddWithValue("@IdPlatillo", idPlatillo);
                    cmd.Parameters.AddWithValue("@IdIngrediente", idIngrediente);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar la relación IngredientePlatillo: " + sqlEx.Message);
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
