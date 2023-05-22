using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioFerreteria.Models
{
    public class VentasObtener : Venta
    {
        public string EmpleadoNombre { get; set; }
        public string ClienteNombre { get; set; }
        public string ProductoNombre { get; set; }

        public IEnumerable<SelectListItem> Clientes { get; set; }
        public IEnumerable<SelectListItem> Empleados { get; set; }
        public IEnumerable<SelectListItem> Productos { get; set; }
    }
}
