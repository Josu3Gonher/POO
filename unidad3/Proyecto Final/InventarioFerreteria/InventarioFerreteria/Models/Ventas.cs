using System.ComponentModel.DataAnnotations;

namespace InventarioFerreteria.Models
{
    public class Ventas
    {
        public int VentasId { get; set; }
        public DateTime Fecha { get; set; }
        public int Cantidad { get; set; }

        [StringLength(maximumLength: 1000)]
        public string Descripcion { get; set; }

        [Display(Name = "Empleado")]
        public int EmpleadoId { get; set; }

        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        [Display(Name = "Producto")]
        public int ProductoId { get; set; }
    }
}
