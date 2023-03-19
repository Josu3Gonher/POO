using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using TareaAplicacionWeb.Models;

namespace TareaAplicacionWeb.Controllers
{
    public class HomeController : Controller
    {
        private static List<Tarea> tareas = new List<Tarea>();
        private readonly ILogger<HomeController> _logger;
        private readonly TareaService _tareaService;

        public HomeController(ILogger<HomeController> logger)
        {
            _tareaService = new TareaService();
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Tareas = tareas;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /************De aqui para abajo lo trabaje yo**************/
        public ActionResult Crear()
        {
            return View();
        }
        //para manejar la solicitud de crear una nueva tarea desde el formulario
       

        [HttpPost]
        public ActionResult Crear(Tarea tarea)
        {
            tareas.Add(tarea);
            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
            Tarea tarea = tareas.Find(t => t.Id == id);
            return View(tarea);
        }

        [HttpPost]
        public ActionResult Editar(Tarea tareaActualizada)
        {
            Tarea tarea = tareas.Find(t => t.Id == tareaActualizada.Id);
            tarea.Titulo = tareaActualizada.Titulo;
            tarea.Descripcion = tareaActualizada.Descripcion;
            tarea.FechaVencimiento = tareaActualizada.FechaVencimiento;
            return RedirectToAction("Index");
        }
        public ActionResult TareasRecientes()
        {
            var tareas = TareaService.ObtenerTareasRecientes();
            return PartialView("_TareasRecientes", tareas);
        }
        public static List<Tarea> ObtenerTareasRecientes()
        {
            return tareas;
        }
        
        //***************Hasta aqui**********************/

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}