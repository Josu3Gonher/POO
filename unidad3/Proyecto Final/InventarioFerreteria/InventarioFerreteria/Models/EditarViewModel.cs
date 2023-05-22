using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioFerreteria.Models
{
    public class EditarViewModel : Producto
    {
        public IEnumerable<SelectListItem> Proveedores { get; set; }
        public IEnumerable<SelectListItem> Categorias { get; set; }
    }
}
