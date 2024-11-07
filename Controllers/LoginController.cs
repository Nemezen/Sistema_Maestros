using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_Maestros.Data;
using Sistema_Maestros.Models;

public class LoginController : Controller
{
    private readonly ApplicationDbContext _context;

    public LoginController(ApplicationDbContext context)
    {
        _context = context;
    }

    // Endpoint: /api/login
    [HttpPost("api/login")]
    public async Task<IActionResult> Login([FromBody] Profesor login)
    {
        // Validar el nombre de usuario y contraseña usando el objeto Profesor
        var usuario = await _context.Profesores
            .FirstOrDefaultAsync(u => u.Nombre_Usuario == login.Nombre_Usuario && u.Contrasenia == login.Contrasenia);

        if (usuario != null)
        {
            // Si las credenciales son válidas, retornar información del usuario
            return Ok(new
            {
                profesorId = usuario.Id,
                profesorNombre = usuario.Nombre,
            });
        }

        // Si las credenciales no son válidas, retornar No Autorizado
        return Unauthorized("Datos incorrectos");
    }
}



