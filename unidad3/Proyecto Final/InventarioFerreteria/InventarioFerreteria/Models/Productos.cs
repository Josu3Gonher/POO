using System.ComponentModel.DataAnnotations;

namespace InventarioFerreteria.Models
{
    public class Productos
    {
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El {0} es requerido.")]
        [StringLength(50, ErrorMessage = "El campo Nombre debe tener entre 2 y 50 caracteres.", MinimumLength = 2)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Marca es requerido.")]
        [StringLength(50, ErrorMessage = "El campo Marca debe tener entre 2 y 50 caracteres.", MinimumLength = 2)]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El campo Precio es requerido.")]
        [Range(1, 1000000, ErrorMessage = "El campo Precio debe ser un número positivo.")]
        public decimal Precio { get; set; }

        [StringLength(250, ErrorMessage = "El campo Descripcion debe tener como máximo 250 caracteres.")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El campo CategoriaId es requerido.")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "El campo ProveedorId es requerido.")]
        public int ProveedorId { get; set; }
    }
}
