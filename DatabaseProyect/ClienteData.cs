using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect;
using SharedModels;

namespace ProyectoData
{
    public class ClienteData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public ClienteData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Obtener la lista de clientes usando un procedimiento almacenado
        public async Task<List<Cliente>> Lista()
        {
            List<Cliente> lista = new List<Cliente>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync(); // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene los clientes
                    SqlCommand cmd = new SqlCommand("sp_listaClientes", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new Cliente
                            {
                                Nombre = reader["Nombre"].ToString(),
                                Email = reader["Email"].ToString(),
                                Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono")) ? 0 : reader.GetInt32(reader.GetOrdinal("Telefono"))
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

        // Crear un nuevo cliente utilizando un procedimiento almacenado
        public async Task<bool> Crear(Cliente cliente)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearCliente", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);

                    await conexion.OpenAsync(); // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear el cliente: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Editar un cliente existente utilizando un procedimiento almacenado
        public async Task<bool> Editar(Cliente cliente)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarCliente", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Email", cliente.Email);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);

                    await conexion.OpenAsync(); // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar el cliente: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Eliminar un cliente utilizando un procedimiento almacenado
        public async Task<bool> Eliminar(string email)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarCliente", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar el parámetro de Email
                    cmd.Parameters.AddWithValue("@Email", email);

                    await conexion.OpenAsync(); // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar el cliente: " + sqlEx.Message);
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
