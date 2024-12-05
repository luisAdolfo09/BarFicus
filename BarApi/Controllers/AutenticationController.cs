using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedModels;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using BarApi.Services;
using DatabaseProyect;
using System.Text;

namespace BarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticationController : ControllerBase
    {
        private readonly string secretKey;
        private readonly UsuarioData _usuarioData;

        public AutenticationController(IConfiguration config, UsuarioData usuarioData)
        {
            secretKey = config.GetSection("settings").GetSection("secretkey").ToString();
            _usuarioData = usuarioData;
        }

        [HttpPost]
        [Route("Validar")]
        public async Task<IActionResult> Validar([FromBody] Usuarios request)
        {
            try
            {
                // 1. Verificar si el correo existe en la base de datos
                var usuario = await _usuarioData.ValidarUsuarioAsync(request.Correo);

                // Si no existe el usuario, regresar Unauthorized
                if (usuario == null)
                {
                    return Unauthorized("Usuario no encontrado");
                }

                // 2. Verificar si la contraseña es correcta
                bool esValida = Seguridad.VerificarContraseña(request.Clave, usuario.Clave);

                // Si la contraseña es incorrecta, regresar Unauthorized
                if (!esValida)
                {
                    return Unauthorized("Contraseña incorrecta");
                }

                // 3. Generar el token JWT si el usuario y la contraseña son correctos
                var keyBytes = Encoding.ASCII.GetBytes(secretKey);
                var claims = new ClaimsIdentity();

                claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, request.Correo));

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = claims,
                    Expires = DateTime.UtcNow.AddMinutes(10), // Expira en 10 minutos
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
                };

                var tokenHandler = new JwtSecurityTokenHandler();
                var tokenConfig = tokenHandler.CreateToken(tokenDescriptor);

                string tokencreado = tokenHandler.WriteToken(tokenConfig);

                // Retornar el token si todo está correcto
                return StatusCode(StatusCodes.Status200OK, new { token = tokencreado });
            }
            catch
            {
                return StatusCode(StatusCodes.Status401Unauthorized, new { token = "" });
            }


             


            // 3. Crear las reclamaciones (claims) para el JWT
            //var claims = new[]
            //{
            //    new Claim(ClaimTypes.NameIdentifier, usuario.Id_Usuario.ToString()),
            //    new Claim(ClaimTypes.Name, usuario.Nombre),
            //    new Claim(ClaimTypes.Email, usuario.Correo),
            //    new Claim("Activo", usuario.Activo.ToString())
            //};

            //// 4. Crear la clave secreta
            //var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));

            //// 5. Crear las credenciales del JWT
            //var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            //// 6. Crear el token JWT
            //var token = new JwtSecurityToken(
            //    issuer: "yourIssuer", // El emisor del token (puedes personalizarlo)
            //    audience: "yourAudience", // El público al que se dirige el token (puedes personalizarlo)
            //    claims: claims,
            //    expires: DateTime.Now.AddMinutes(30), // Establecer el tiempo de expiración (por ejemplo 30 minutos)
            //    signingCredentials: creds
            //);

            //// 7. Devolver el token JWT
            //return Ok(new
            //{
            //    token = new JwtSecurityTokenHandler().WriteToken(token)
            //});
        }

    }
}
    

