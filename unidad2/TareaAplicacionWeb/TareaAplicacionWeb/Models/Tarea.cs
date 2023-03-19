using System.Globalization;

namespace TareaAplicacionWeb.Models
{
    public class Tarea
    {
        public int Id { get; set; } //recordar que despues tengo que modificarlo Codigo
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
   
}
