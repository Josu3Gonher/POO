using Microsoft.AspNetCore.Mvc;
using Portafolio.Interfaces;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorioProyectos repositorioProyectos;
        //private readonly IConfiguration configuration;

        public HomeController(
            ILogger<HomeController> logger,
            IRepositorioProyectos repositorioProyectos
            //IConfiguration configuration
            )
        {
            _logger = logger;
            this.repositorioProyectos = repositorioProyectos;
            //this.configuration = configuration;
        }

        public IActionResult Index()
        {
            /*
             * LogTrace
             * LogDebug
             * LogInformation
             * LogWarning
             * LogError
             * LogCritical
             */

            //_logger.LogTrace("Este es un mensaje de Trace");
            //_logger.LogDebug("Este es un mensaje de Debug");
            //_logger.LogInformation("Este es un mensaje de Information");
            //_logger.LogWarning("Este es un mensaje de Warning");
            //_logger.LogError("Este es un mensaje de Error");
            //_logger.LogCritical("Este es un mensaje de Trace");

            //var apellido = configuration.GetValue<string>("apellido");

            //_logger.LogInformation("El apellido es: " + apellido);

            var proyectos = this.repositorioProyectos.ObtenerProyectos().Take(3).ToList();

            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }


        public IActionResult Proyectos()
        {
            var proyectos = repositorioProyectos.ObtenerProyectos();
            return View(proyectos);
        }

        public IActionResult Contacto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contactoViewModel)
        {
            _logger.LogCritical(contactoViewModel.Nombre);
            return RedirectToAction("Gracias");
        }

        public IActionResult Gracias()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

//ServicioTransitorio servicioTransitorio,
//ServicioDelimitado servicioDelimitado,
//ServicioUnico servicioUnico,
//ServicioTransitorio servicioTransitorio2,
//ServicioDelimitado servicioDelimitado2,
//ServicioUnico servicioUnico2

//this.servicioTransitorio = servicioTransitorio;
//this.servicioDelimitado = servicioDelimitado;
//this.servicioUnico = servicioUnico;
//this.servicioTransitorio2 = servicioTransitorio2;
//this.servicioDelimitado2 = servicioDelimitado2;
//this.servicioUnico2 = servicioUnico2;

//var guidViewModel = new EjemploGuidViewModel
//{
//    Transitorio = servicioTransitorio.ObtenerGuid,
//    Delimitado = servicioDelimitado.ObtenerGuid,
//    Unico = servicioUnico.ObtenerGuid
//};

//var guidViewModel2 = new EjemploGuidViewModel
//{
//    Transitorio = servicioTransitorio2.ObtenerGuid,
//    Delimitado = servicioDelimitado2.ObtenerGuid,
//    Unico = servicioUnico2.ObtenerGuid
//};