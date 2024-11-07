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
    public async Task<IActionResult> Login(Profesor profesor)
    {
        // Buscar usuario en la base de datos
        var usuario = await _context.Profesores
            .FirstOrDefaultAsync(u => u.Nombre == profesor.Nombre && u.Contrasenia == profesor.Contrasenia);

        if (usuario != null)
        {
            // Si las credenciales son válidas, retornar información del usuario
            return Ok(new
            {
                usuarioId = usuario.Id,
                usuarioNombre = usuario.Nombre,
            });
        }

        // Si las credenciales no son válidas, retornar No Autorizado
        return Unauthorized("Credenciales incorrectas");
    }
}

