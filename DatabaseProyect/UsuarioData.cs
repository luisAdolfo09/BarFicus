using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using System.Data.SqlClient;
using System.Data;
using SharedModels;

namespace DatabaseProyect
{
    public class UsuarioData
    {
        private readonly ConnectionStrings _conexiones;

        // Constructor para recibir las opciones de conexión
        public UsuarioData(IOptions<ConnectionStrings> options)
        {
            _conexiones = options.Value;
        }

        // Método para validar al usuario
        public async Task<Usuarios?> ValidarUsuarioAsync(string correo)
        {
            Usuarios? usuario = null;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();

                    SqlCommand cmd = new SqlCommand("sp_validarUsuario", conexion)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Parameters.AddWithValue("@Correo", correo);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            usuario = new Usuarios
                            {
                                Id_Usuario = reader.GetInt32(reader.GetOrdinal("Id_Usuario")),
                                Correo = reader.GetString(reader.GetOrdinal("Correo")),
                                Clave = reader.GetString(reader.GetOrdinal("Clave")), // Contraseña cifrada
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Activo = reader.GetBoolean(reader.GetOrdinal("Activo"))
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return usuario;
        }

        // Método para obtener todos los usuarios
        public async Task<List<Usuarios>> Lista()
        {
            var usuarios = new List<Usuarios>();

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios", conexion);
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var usuario = new Usuarios
                            {
                                Id_Usuario = reader.GetInt32(reader.GetOrdinal("Id_Usuario")),
                                Correo = reader.GetString(reader.GetOrdinal("Correo")),
                                Clave = reader.GetString(reader.GetOrdinal("Clave")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Activo = reader.GetBoolean(reader.GetOrdinal("Activo"))
                            };
                            usuarios.Add(usuario);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return usuarios;
        }

        // Método para obtener un usuario por su ID
        public async Task<Usuarios?> ObtenerPorId(int id)
        {
            Usuarios? usuario = null;

            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM Usuarios WHERE Id_Usuario = @Id", conexion);
                    cmd.Parameters.AddWithValue("@Id", id);

                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            usuario = new Usuarios
                            {
                                Id_Usuario = reader.GetInt32(reader.GetOrdinal("Id_Usuario")),
                                Correo = reader.GetString(reader.GetOrdinal("Correo")),
                                Clave = reader.GetString(reader.GetOrdinal("Clave")),
                                Nombre = reader.GetString(reader.GetOrdinal("Nombre")),
                                Activo = reader.GetBoolean(reader.GetOrdinal("Activo"))
                            };
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
            }

            return usuario;
        }

        // Método para crear un nuevo usuario
        public async Task<bool> Crear(Usuarios usuario)
        {
            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (Nombre, Correo, Clave, Activo) VALUES (@Nombre, @Correo, @Clave, @Activo)", conexion);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Clave", usuario.Clave); // Asegúrate de cifrar la contraseña antes de guardarla
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                return false;
            }
        }

        // Método para editar un usuario
        public async Task<bool> Editar(Usuarios usuario)
        {
            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();

                    SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET Nombre = @Nombre, Correo = @Correo, Clave = @Clave, Activo = @Activo WHERE Id_Usuario = @Id_Usuario", conexion);
                    cmd.Parameters.AddWithValue("@Id_Usuario", usuario.Id_Usuario);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo);
                    cmd.Parameters.AddWithValue("@Clave", usuario.Clave); // Asegúrate de cifrar la contraseña antes de guardarla
                    cmd.Parameters.AddWithValue("@Activo", usuario.Activo);

                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                return false;
            }
        }

        // Método para eliminar un usuario
        public async Task<bool> Eliminar(int id)
        {
            try
            {
                using (var conexion = new SqlConnection(_conexiones.CadenaSQL))
                {
                    await conexion.OpenAsync();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Usuarios WHERE Id_Usuario = @Id_Usuario", conexion);
                    cmd.Parameters.AddWithValue("@Id_Usuario", id);

                    int rowsAffected = await cmd.ExecuteNonQueryAsync();
                    return rowsAffected > 0;
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error SQL: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error general: " + ex.Message);
                return false;
            }
        }
    }
}
