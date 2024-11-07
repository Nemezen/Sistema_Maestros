namespace Sistema_Maestros.Models
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; } = null!;
        public Profesor Profesor { get; set; } = new Profesor();

    }
}
