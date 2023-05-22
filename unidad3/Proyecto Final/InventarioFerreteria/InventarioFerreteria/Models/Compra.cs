using System.ComponentModel.DataAnnotations;

namespace InventarioFerreteria.Models
{
    public class Compra
    {
        public int ComprasId { get; set; }

        [Display(Name = "Producto")]
        [Required(ErrorMessage = "El {0} del producto es requerido")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "La {0} es requerida")]
        [Range(1, int.MaxValue, ErrorMessage = "La {0} debe ser un número positivo")]
        public int Cantidad { get; set; }

        [StringLength(1000, ErrorMessage = "La {0} debe tener como máximo {1} caracteres")]
        public string Descripcion { get; set; }

        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "El {0} del es requerido")]
        public int ProveedorId { get; set; }

        [Required(ErrorMessage = "La {0} es requerida")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        public Compra compra { get; set; }
        public string ProductoNombre { get; set; }
        public string ProveedorNombre { get; set; }
        
    }
}
