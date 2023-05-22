using System.ComponentModel.DataAnnotations;

namespace InventarioFerreteria.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe tener como máximo {1} caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [StringLength(50, ErrorMessage = "El {0} debe tener como máximo {1} caracteres")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La {0} es requerida")]
        [StringLength(400, ErrorMessage = "La {0} debe tener como máximo {1} caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Range(10000, 9999999999999, ErrorMessage = "El {0} debe ser un número de 8 dígitos")]
        public string Dni { get; set; }

        [Required(ErrorMessage = "El {0} es requerido")]
        [Range(1000, 99999999999, ErrorMessage = "El {0} debe ser un número de 9 dígitos")]
        public string Telefono { get; set; }
    }
}

