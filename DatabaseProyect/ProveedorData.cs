using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using DatabaseProyect;
using SharedModels;

namespace ProyectoData
{
    public class ProveedorData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para inyectar las opciones de conexión
        public ProveedorData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Crear un nuevo proveedor utilizando un procedimiento almacenado
        public async Task<bool> Crear(Proveedor objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_crearProveedor", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@Contacto", objeto.Contacto);
                    cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.Parameters.AddWithValue("@Correo", objeto.Correo);

                    // Agregar un parámetro de salida para obtener el IdProveedor
                    SqlParameter outputIdParam = new SqlParameter("@IdProveedor", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputIdParam);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    if (await cmd.ExecuteNonQueryAsync() > 0)
                    {
                        // Asignar el IdProveedor al objeto recibido
                        objeto.IdProveedor = (int)outputIdParam.Value;
                    }
                    else
                    {
                        respuesta = false;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al crear el proveedor: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        public async Task<bool> Editar(Proveedor objeto)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_editarProveedor", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar los parámetros al procedimiento almacenado
                    cmd.Parameters.AddWithValue("@IdProveedor", objeto.IdProveedor);
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@Contacto", objeto.Contacto);
                    cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.Parameters.AddWithValue("@Correo", objeto.Correo);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al editar el proveedor: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        public async Task<bool> Eliminar(int id)
        {
            bool respuesta = true;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    SqlCommand cmd = new SqlCommand("sp_eliminarProveedor", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Pasar el parámetro de IdProveedor
                    cmd.Parameters.AddWithValue("@IdProveedor", id);

                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Ejecutar el procedimiento y verificar si afectó filas
                    respuesta = await cmd.ExecuteNonQueryAsync() > 0;
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("Error al eliminar el proveedor: " + sqlEx.Message);
                respuesta = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                respuesta = false;
            }

            return respuesta;
        }

        public async Task<object> Lista()
        {
            List<Proveedor> lista = new List<Proveedor>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();  // Abrir la conexión de manera asíncrona

                    // Llamar al procedimiento almacenado que obtiene los proveedores
                    SqlCommand cmd = new SqlCommand("sp_listaProveedores", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    // Ejecutar el procedimiento almacenado y leer los datos
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            lista.Add(new Proveedor
                            {
                                IdProveedor = reader.GetInt32(reader.GetOrdinal("Id_Proveedor")),
                                Nombre = reader["Nombre"].ToString(),
                                Contacto = reader["Contacto"].ToString(),
                                Telefono = reader["Telefono"].ToString(),
                                Direccion = reader["Direccion"].ToString(),
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
    }

        // Otros métodos (Lista, Editar, Eliminar) permanecen igual.
 }
