using Microsoft.AspNetCore.Identity;
using System.Text;
using BCrypt.Net;

namespace BarApi.Services
{
    public static class Seguridad
    {
        public static string CifrarContraseña(string contraseña)
        {
            return BCrypt.Net.BCrypt.HashPassword(contraseña);
        }

        // Método para verificar si la contraseña ingresada coincide con la guardada (cifrada)
        public static bool VerificarContraseña(string contraseñaIngresada, string contraseñaGuardada)
        {
            return BCrypt.Net.BCrypt.Verify(contraseñaIngresada, contraseñaGuardada);  // Asegúrate de usar BCrypt.Net
        }
    }
}
