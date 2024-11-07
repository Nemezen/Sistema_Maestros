namespace Sistema_Maestros.Models
{
    public class Alumno
    {

        public int AlumnoId { get; set; }
        public string Nombre { get; set; } = null!;
        public List<Materia> Materias { get; set; } = new List<Materia>();
        

    }
}
