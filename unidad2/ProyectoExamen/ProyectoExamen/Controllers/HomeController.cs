using Microsoft.AspNetCore.Mvc;
using ProyectoExamen.Interfaces;
using ProyectoExamen.Models;
using System.Diagnostics;

namespace ProyectoExamen.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlumnoServicio _alumno;

        public HomeController(ILogger<HomeController> logger, IAlumnoServicio alumnoServicio)
        {

            _logger = logger;
            _alumno = alumnoServicio;
        }


        public IActionResult Index()
        {
            var alumnos = _alumno.ObtenerAlumnos();
            var homeViewModel = new HomeViewController { Alumnos = alumnos };
            return View(homeViewModel);
        }
        public IActionResult TomarAsistencia()
        {
            var alumnos = _alumno.ObtenerAlumnos();
            var homeViewModel = new HomeViewController { Alumnos = alumnos };
            return View(homeViewModel);
        }
        public IActionResult Editar(Guid id)
        {
            var alumno = _alumno.ObtenerAlumno(id);
            return View("Editar", alumno);
        }
        public IActionResult Integrantes() 
        {
            return View();
        }


        [HttpPost]
        public IActionResult Editar(Alumno alumno)
        {
            _alumno.EditarAlumno(alumno);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}