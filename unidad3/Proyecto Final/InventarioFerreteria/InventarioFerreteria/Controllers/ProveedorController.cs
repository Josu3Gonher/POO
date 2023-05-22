using InventarioFerreteria.Models;
using InventarioFerreteria.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace InventarioFerreteria.Controllers
{
    public class ProveedorController : Controller
    {
        private readonly IRepositorioProveedor repositorioProveedor;
        private readonly IRepositorioProductos repositorioProductos;

        public ProveedorController(IRepositorioProveedor repositorioProveedor,
            IRepositorioProductos repositorioProductos)
        {
            this.repositorioProveedor = repositorioProveedor;
            this.repositorioProductos = repositorioProductos;
        }

        public async Task<IActionResult> Index()
        {
            var proveedor = await repositorioProveedor.ObtenerProveedores();
            return View(proveedor);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Proveedor proveedor)
        {
            if (!ModelState.IsValid)
            {
                return View(proveedor);
            }

            var categoriaDb = await repositorioProveedor.Crear(proveedor);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int ProveedorId)
        {
            var proveedor = await repositorioProveedor.ObtenerProveedorId(ProveedorId);

            var editarProveedor = new Proveedor
            {

                Nombre = proveedor.Nombre,
                Telefono = proveedor.Telefono

            };

            if (proveedor == null)
            {
                return RedirectToAction("Index");
            }
            return View(editarProveedor);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Proveedor proveedorEditar)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            await repositorioProveedor.Editar(proveedorEditar);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Borrar(int proveedorId)
        {
            var proveedor = await repositorioProveedor.ObtenerProveedorId(proveedorId);

            if (proveedor is null)
            {
                return RedirectToAction("Index", "Proveedor");
            }

            return View(proveedor);
        }

        [HttpPost]
        public async Task<IActionResult> BorrarProveedor(int proveedorId)
        {
            var proveedor = await repositorioProveedor.ObtenerProveedorId(proveedorId);

            if (proveedor is null)
            {
                return RedirectToAction("Index", "Home");
            }

            await repositorioProveedor.Borrar(proveedorId);

            return RedirectToAction("Index");

        }
    }
}
