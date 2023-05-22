using ProyectoExamen.Models;

namespace ProyectoExamen.Interfaces
{
    public interface IAlumnoServicio
    {
        List<Alumno> ObtenerAlumnos();
        public Alumno ObtenerAlumno(Guid id);
        public void EditarAlumno(Alumno alumno);
    }
    
}
