using InventarioFerreteria.Models;
using InventarioFerreteria.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioFerreteria.Controllers
{
    public class CompraController : Controller
    {
        private readonly IRepositorioCompra repositorioCompra;
        private readonly IRepositorioProductos repositorioProductos;
        private readonly IRepositorioProveedor repositorioProveedor;

        public CompraController(IRepositorioCompra repositorioCompra,
            IRepositorioProductos repositorioProductos,
            IRepositorioProveedor repositorioProveedor)
        {
            this.repositorioCompra = repositorioCompra;
            this.repositorioProductos = repositorioProductos;
            this.repositorioProveedor = repositorioProveedor;
        }

        public async Task<IActionResult> Index()
        {
            var compras = await repositorioCompra.ObtenerCompras();
            return View(compras);
        }

        [HttpGet]
        public async Task<IActionResult> Crear()
        {
            var proveedores = await repositorioProveedor.ObtenerProveedores();
            var productos = await repositorioProductos.Obtener();

            var proveedoresListItem = proveedores.Select
            (proveedor => new SelectListItem(proveedor.Nombre, proveedor.ProveedorId.ToString()));
            var productosListItem = productos.Select
            (producto => new SelectListItem(producto.Nombre, producto.ProductoId.ToString()));

            var obtenerCompra = new CompraViewModel
            {
                Proveedores = proveedoresListItem,
                Productos = productosListItem
            };

            return View(obtenerCompra);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Compra compra)
        {
            if (!ModelState.IsValid)
            {
                return View(compra);
            }

            var compraDb = await repositorioCompra.Crear(compra);

            return RedirectToAction("Index");
        }
    }
}
