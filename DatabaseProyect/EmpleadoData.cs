using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect;  // Asegúrate de que esta referencia esté bien configurada
using SharedModels;     // Referencia a la clase Empleado

namespace ProyectoData
{
    public class EmpleadoData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public EmpleadoData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Obtener la lista de empleados usando un procedimiento almacenado
        public async Task<List<Empleados>> Lista()
        {
            List<Empleados> lista = new List<Empleados>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene los empleados
                    SqlCommand cmd = new SqlCommand("sp_listaEmpleados", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new Empleados
                            {
                                IdEmpleado = reader.GetInt32(reader.GetOrdinal("Id_empleado")),
                                PrimerNombre = reader["PrimerNombre"].ToString(),
                                PrimerApellido = reader["Primer_apellido"].ToString(),
                                SegundoApellido = reader["Segundo_apellido"].ToString(),
                                Puesto = reader["Puesto"].ToString(),
                                Antiguedad = reader.GetInt32(reader.GetOrdinal("Antiguedad")),
                                CedulaIdentidad = reader["Cedula_identidad"].ToString(),
                                Telefono = reader.GetInt32(reader.GetOrdinal("Telefono"))
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

        // Crear un nuevo empleado utilizando un procedimiento almacenado
        public async Task<bool> Crear(Empleados objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearEmpleado", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@PrimerNombre", objeto.PrimerNombre);
                    cmd.Parameters.AddWithValue("@PrimerApellido", objeto.PrimerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", objeto.SegundoApellido);
                    cmd.Parameters.AddWithValue("@Puesto", objeto.Puesto);
                    cmd.Parameters.AddWithValue("@Antiguedad", objeto.Antiguedad);
                    cmd.Parameters.AddWithValue("@CedulaIdentidad", objeto.CedulaIdentidad);
                    cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear el empleado: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Editar un empleado existente utilizando un procedimiento almacenado
        public async Task<bool> Editar(Empleados objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarEmpleado", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdEmpleado", objeto.IdEmpleado);
                    cmd.Parameters.AddWithValue("@PrimerNombre", objeto.PrimerNombre);
                    cmd.Parameters.AddWithValue("@PrimerApellido", objeto.PrimerApellido);
                    cmd.Parameters.AddWithValue("@SegundoApellido", objeto.SegundoApellido);
                    cmd.Parameters.AddWithValue("@Puesto", objeto.Puesto);
                    cmd.Parameters.AddWithValue("@Antiguedad", objeto.Antiguedad);
                    cmd.Parameters.AddWithValue("@CedulaIdentidad", objeto.CedulaIdentidad);
                    cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar el empleado: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        // Eliminar un empleado utilizando un procedimiento almacenado
        public async Task<bool> Eliminar(int id)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarEmpleado", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar el parámetro de IdEmpleado
                    cmd.Parameters.AddWithValue("@IdEmpleado", id);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar el empleado: " + sqlEx.Message);
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