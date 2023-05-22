namespace ProyectoExamen.Models
{
    public class Alumno
    {
        public Guid Id { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public bool Asistencia { get; set; }
    }
}
