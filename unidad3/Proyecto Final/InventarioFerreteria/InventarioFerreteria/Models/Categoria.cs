using System.ComponentModel.DataAnnotations;

namespace InventarioFerreteria.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50,
            MinimumLength = 3, ErrorMessage = "El campo {0} debe tener entre {2} y {1} letras")]
        public string Nombre { get; set; }

        [StringLength(300, ErrorMessage = "El campo {0} debe tener como máximo {1} caracteres")]
        public string Descripcion { get; set; }

        public Categoria categoria { get; set; }
    }
}
