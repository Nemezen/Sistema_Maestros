using Microsoft.EntityFrameworkCore;
using Sistema_Maestros.Models;

namespace Sistema_Maestros.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
    }
}

