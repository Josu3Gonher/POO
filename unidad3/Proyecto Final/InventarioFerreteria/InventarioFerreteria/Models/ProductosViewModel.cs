using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioFerreteria.Models
{
    public class ProductosViewModel
    {
        public IEnumerable<SelectListItem> Proveedores { get; set; }
        public IEnumerable<SelectListItem> Categoria { get; set; }
        public Producto Producto { get; set; }
    }
}
