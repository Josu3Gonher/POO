using InventarioFerreteria.Models;
using InventarioFerreteria.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace InventarioFerreteria.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly IRepositorioCategoria repositorioCategoria;
        private readonly IRepositorioProductos repositorioProductos;

        public CategoriaController(IRepositorioCategoria repositorioCategoria,
            IRepositorioProductos repositorioProductos)
        {
            this.repositorioCategoria = repositorioCategoria;
            this.repositorioProductos = repositorioProductos;
        }

        public async Task<IActionResult> Index()
        {
            var categoria = await repositorioCategoria.ObtenerCategoria();
            return View(categoria);
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Crear(Categoria categoria)
        {
            if (!ModelState.IsValid)
            {
                return View(categoria);
            }

            var categoriaDb = await repositorioCategoria.Crear(categoria);

            return RedirectToAction("Index");
        }

        //[HttpGet]
        //public async Task<IActionResult> Borrar(int CategoriaId)
        //{
        //    var categoria = await repositorioCategoria.ObtenerCategoriaId(CategoriaId);

        //    if (categoria is null)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }

        //    return View(categoria);
        //}

        [HttpGet]
        public async Task<IActionResult> Editar(int CategoriaId)
        {
            var categoria = await repositorioCategoria.ObtenerCategoriaId(CategoriaId);

            var editarCategoria = new Categoria
            {
                
                Nombre = categoria.Nombre,
                Descripcion = categoria.Descripcion,
        
            };

            if (categoria == null)
            {
                return RedirectToAction("Index");
            }
            return View(editarCategoria);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(Categoria categoriaEditar)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            await repositorioCategoria.Editar(categoriaEditar);

            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public async Task<IActionResult> BorrarCategoria(int CategoriaId)
        //{
        //    var categoria = await repositorioCategoria.ObtenerCategoriaId(CategoriaId);

        //    if (categoria is null)
        //    {
        //        return RedirectToAction("Index", "Home");
        //    }

        //    await repositorioCategoria.Borrar(CategoriaId);

        //    return RedirectToAction("Index");

        //}
    }
}
