using InventarioFerreteria.Models;
using InventarioFerreteria.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace InventarioFerreteria.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly IRepositorioEmpleado repositorioEmpleado;
        private readonly IRepositorioProductos repositorioProductos;

        public EmpleadoController(IRepositorioEmpleado repositorioEmpleado,
            IRepositorioProductos repositorioProductos)
        {
            this.repositorioEmpleado = repositorioEmpleado;
            this.repositorioProductos = repositorioProductos;
        }

        public async Task<IActionResult> Index()
        {
            var empleados = await repositorioEmpleado.ObtenerEmpleados();
            return View(empleados);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Empleado empleado)
        {
            if (!ModelState.IsValid)
            {
                return View(empleado);
            }

            var empleadoDb = await repositorioEmpleado.Crear(empleado);

            return RedirectToAction("Index", "Empleados");
        }
        [HttpGet]
        public async Task<IActionResult> Borrar(int empleadoId)
        {
            var empleado = await repositorioEmpleado.ObtenerEmpleadoId(empleadoId);

            if (empleado is null)
            {
                return RedirectToAction("Index", "Empleado");
            }

            return View(empleado);
        }

        [HttpPost]
        public async Task<IActionResult> BorrarEmpleado(int empleadoId)
        {
            var empleado = await repositorioEmpleado.ObtenerEmpleadoId(empleadoId);

            if (empleado is null)
            {
                return RedirectToAction("Index", "Empleado");
            }

            await repositorioEmpleado.Borrar(empleadoId);

            return RedirectToAction("Index");

        }
    }
}
