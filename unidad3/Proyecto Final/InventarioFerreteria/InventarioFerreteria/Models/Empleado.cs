using System.ComponentModel.DataAnnotations;

namespace InventarioFerreteria.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(maximumLength: 50,
            MinimumLength = 3, ErrorMessage = "El campo {0} debe tener entre {2} y {1} letras")]
        public string Nombre { get; set; }

        [Display(Name = "Codigo de Empleado")]
        [Required(ErrorMessage = "El {0} es requerido")]
        [Range(2, int.MaxValue, ErrorMessage = "El {0} debe ser un número positivo")]
        public int CodigoEmpleado { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe tener como máximo {1} caracteres")]
        public string Cargo { get; set; }
    }
}
