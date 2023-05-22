using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioFerreteria.Models
{
    public class CompraViewModel : Compra
    {
        public IEnumerable<SelectListItem> Productos { get; set; }
        public IEnumerable<SelectListItem> Proveedores { get; set; }
    }
}
