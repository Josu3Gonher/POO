using InventarioFerreteria.Models;
using InventarioFerreteria.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace InventarioFerreteria.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IRepositorioCliente repositorioCliente;
        private readonly IRepositorioProductos repositorioProductos;

        public ClienteController(IRepositorioCliente repositorioCliente,
            IRepositorioProductos repositorioProductos)
        {
            this.repositorioCliente = repositorioCliente;
            this.repositorioProductos = repositorioProductos;
        }

        public async Task<IActionResult> Index()
        {
            var clientes = await repositorioCliente.ObtenerClientes();
            return View(clientes);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }

            var clienteDb = await repositorioCliente.Crear(cliente);

            return RedirectToAction("Index", "Cliente");
        }

        [HttpGet]
        public async Task<IActionResult> Borrar(int clienteId)
        {
            var cliente = await repositorioCliente.ObtenerClienteId(clienteId);

            if (cliente is null)
            {
                return RedirectToAction("Index", "Cliente");
            }

            return View(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> BorrarCliente(int clienteId)
        {
            var cliente = await repositorioCliente.ObtenerClienteId(clienteId);

            if (cliente is null)
            {
                return RedirectToAction("Index", "Cliente");
            }

            await repositorioCliente.Borrar(clienteId);

            return RedirectToAction("Index");

        }
    }
}
