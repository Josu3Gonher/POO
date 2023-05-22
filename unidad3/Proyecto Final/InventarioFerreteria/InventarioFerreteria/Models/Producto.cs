using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InventarioFerreteria.Models
{
    public class Producto : IValidatableObject
    {
        public int ProductoId { get; set; }

        
        [Required(ErrorMessage = "El {0} es requerido")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerid")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Precio { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "El {0} es requerido")]
        public int CategoriaId { get; set; }

        [Display(Name = "Proveedor")]
        [Required(ErrorMessage = "El {0} es requerido")]
        public int ProveedorId { get; set; }

        [StringLength(1000, ErrorMessage = "La {0} debe tener como máximo {1} caracteres")]
        public string Descripcion { get; set; }




        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Nombre != null && Nombre.Length > 0)
            {
                var primeraLetra = Nombre.ToString()[0].ToString();
                if (primeraLetra != primeraLetra.ToUpper())
                {
                    yield return new ValidationResult("La primera letra deber ser mayuscula",
                        new[] { nameof(Nombre) });
                }
            }
        }
    }
}
