using InventarioFerreteria.Models;
using InventarioFerreteria.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioFerreteria.Controllers
{
    public class VentaController : Controller
    {
        private readonly IRepositorioVenta repositorioVenta;
        private readonly IRepositorioProductos repositorioProductos;
        private readonly IRepositorioEmpleado repositorioEmpleado;
        private readonly IRepositorioCliente repositorioCliente;

        public VentaController(IRepositorioVenta repositorioVenta,
            IRepositorioProductos repositorioProductos,
            IRepositorioEmpleado repositorioEmpleado,
            IRepositorioCliente repositorioCliente)
        {
            this.repositorioVenta = repositorioVenta;
            this.repositorioProductos = repositorioProductos;
            this.repositorioEmpleado = repositorioEmpleado;
            this.repositorioCliente = repositorioCliente;
        }

        public async Task<IActionResult> Index()
        {
            var ventas = await repositorioVenta.ObtenerVentas();
            return View(ventas);
        }

        [HttpGet]
        public async Task<IActionResult> Crear()
        {
            var empleados = await repositorioEmpleado.ObtenerEmpleados();
            var productos = await repositorioProductos.Obtener();
            var clientes = await repositorioCliente.ObtenerClientes();

            var ventasListItem = empleados.Select
            (empleado => new SelectListItem(empleado.Nombre, empleado.EmpleadoId.ToString()));
            var productosListItem = productos.Select
            (producto => new SelectListItem(producto.Nombre, producto.ProductoId.ToString()));
            var clientesListItem = clientes.Select
            (cliente => new SelectListItem(cliente.Nombre, cliente.ClienteId.ToString()));

            var obtenerEmpleado = new VentasObtener
            {
               Empleados = ventasListItem,
               Productos = productosListItem,
               Clientes = clientesListItem

            };
            return View(obtenerEmpleado);  
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Venta venta)
        {
            if (!ModelState.IsValid)
            {
                return View(venta);
            }

            var ventaDb = await repositorioVenta.Crear(venta);

            return RedirectToAction("Index", "Venta");
        }
    }
}

