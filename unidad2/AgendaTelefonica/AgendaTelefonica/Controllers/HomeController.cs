using AgendaTelefonica.Interfaces;
using AgendaTelefonica.Models;
using AgendaTelefonica.Servicios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using static AgendaTelefonica.Models.DatosContacto;

namespace AgendaTelefonica.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioContactos _contacto;

        public HomeController(ILogger<HomeController> logger, IRepositorioContactos repositorioContactos)
        {
            _logger = logger;
            _contacto = repositorioContactos;
        }

        public IActionResult Index()
        {
            var contactos = _contacto.ObtenerContactos();
            var homeViewController = new HomeViewController { Contactos = contactos };
            return View(homeViewController);
        }
        public static List<DatosContacto> listaContactos = new List<DatosContacto>();

        public IActionResult AggInformacion()
        {
            var contactos = _contacto.ObtenerContactos();
            var homeViewController = new HomeViewController { Contactos = contactos };
            return View(homeViewController);
        }

        public IActionResult EditarContacto(Guid id)
        {
            var contacto = _contacto.ObtenerContactos(id);
            return View("EditarContacto", contacto);
        }

        public IActionResult Privacy()
        {
            return View();
        }
       

        [HttpPost]
        public IActionResult EditarContacto(DatosContacto contacto)
        {
            _contacto.EditarContacto(contacto);
            return RedirectToAction("Index");

        }
        [HttpPost]
        public IActionResult AddContacto(DatosContacto contacto)
        {
            _contacto.EditarContacto(contacto);
                return RedirectToAction("AddContacto");
        }



            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        
    }
}