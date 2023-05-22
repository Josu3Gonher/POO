using ProyectoExamen.Interfaces;
using ProyectoExamen.Models;

namespace ProyectoExamen.Servicios
{
    public class AlumnoServicio : IAlumnoServicio
    {
        public List<Alumno> Alumnos { get; set; } = new List<Alumno>
            {
                new Alumno {Id = Guid.NewGuid(), Nombre = "Juan", Apellido = "Perez", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Maria", Apellido = "Pancracia", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Lesvi", Apellido = "Flores", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Joel", Apellido = "Gonzalez", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Josue", Apellido = "Gonzalez", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Irma", Apellido = "Hernandez", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Pedro", Apellido = "Gonzalez", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Ramon", Apellido = "Gonzalez", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Nimia", Apellido = "Murcia", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Lesbi", Apellido = "Hernandez", Asistencia = false},
                new Alumno {Id = Guid.NewGuid(), Nombre = "Sidia", Apellido = "Hernadez", Asistencia = false},
            };

        public void EditarAlumno(Alumno alumno)
        {
            var alumnoAEditar = Alumnos.FirstOrDefault(a => a.Id == alumno.Id);
            alumnoAEditar.Nombre = alumno.Nombre;
            alumnoAEditar.Apellido = alumno.Apellido;
            alumnoAEditar.Asistencia = alumno.Asistencia;
        }

        public Alumno ObtenerAlumno(Guid id)
        {
            var alumno = Alumnos.FirstOrDefault(alumno => alumno.Id == id);
            return alumno;
        }

        public List<Alumno> ObtenerAlumnos()
        {
            return Alumnos;
		}
    }
}
