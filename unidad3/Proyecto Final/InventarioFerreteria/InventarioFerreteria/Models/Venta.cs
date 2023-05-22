using System.ComponentModel.DataAnnotations;

namespace InventarioFerreteria.Models
{
    public class Venta
    {
        public int VentasId { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El Campo {0} es requerido")]
        public int Cantidad { get; set; }
        
        [Display(Name = "Empleado")]
        [Required(ErrorMessage = "El Campo {0} es requerido")]
        public int EmpleadoId { get; set; }

        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "El Campo {0} es requerido")]
        public int ClienteId { get; set; }

        [Display(Name = "Producto")]
        [Required(ErrorMessage = "El Campo {0} es requerido")]
        public int ProductoId { get; set; }

        public Venta venta { get; set; }
    }
}
