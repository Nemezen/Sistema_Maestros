namespace Sistema_Maestros.Models
{
    public class Actividad
    {
        public int ActividadId { get; set; }
        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime FechaEntrega { get; set; }
        public Materia MateriaId { get; set; } = new Materia();
    }
}
