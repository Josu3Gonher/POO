using System.ComponentModel.DataAnnotations;

namespace InventarioFerreteria.Models
{
    public class Proveedor
    {
        public int ProveedorId { get; set; }

        [Required(ErrorMessage = " El {0} es un campo obligatorio")]
        [StringLength(maximumLength: 50,
            MinimumLength = 3, ErrorMessage = "El campo {0} debe tener entre {2} y {1} letras")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = " El {0} es un campo obligatorio")]
        public int Telefono { get; set; }

        public Proveedor proveedor { get; set; }
    }
}
