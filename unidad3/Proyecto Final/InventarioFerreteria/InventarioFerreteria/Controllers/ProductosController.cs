using InventarioFerreteria.Models;
using InventarioFerreteria.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace InventarioFerreteria.Controllers
{
    public class ProductosController : Controller
    {
        private readonly IRepositorioProductos repositorioProductos;
        private readonly IRepositorioProveedor repositorioProveedor;
        private readonly IRepositorioCategoria repositorioCategoria;
        private string connectionString;

        public ProductosController(IRepositorioProductos repositorioProductos,
            IRepositorioProveedor repositorioProveedor,
            IRepositorioCategoria repositorioCategoria)
        {
            this.repositorioProductos = repositorioProductos;
            this.repositorioProveedor = repositorioProveedor;
            this.repositorioCategoria = repositorioCategoria;
        }

        public async Task<IActionResult> Index()
        {
            var productos = await repositorioProductos.Obtener();

            return View(productos);
        }

        [HttpGet]
        public async Task<IActionResult> ObtenerProducto(int productoId)
        {
            var producto = await repositorioProductos.ObtenerProductoId(productoId);

            if (producto == null)
            {
                return RedirectToAction("ProductoNoExiste", "Home");
            }

            var editarViewModel = new EditarViewModel
            {
                ProductoId = producto.ProductoId,
                Nombre = producto.Nombre,
                Marca = producto.Marca,
                Precio = producto.Precio,
                Descripcion = producto.Descripcion,
                CategoriaId = producto.CategoriaId
            };
            return View(editarViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> ObtenerProducto(int productoId, int proveedorId, EditarViewModel editarViewModel)
        {
            if (productoId != editarViewModel.ProductoId || proveedorId != editarViewModel.ProveedorId)
            {
                return RedirectToAction("ProductoNoExiste", "Home");
            }
            if (!ModelState.IsValid)
            {
                //return View(editarViewModel);
                return RedirectToAction("Index");
            }

            return View(editarViewModel);
        }

        private async Task<IEnumerable<SelectListItem>> ObtenerListaProveedores()
        {
            var proveedores = await repositorioProveedor.ObtenerProveedores();
            var listaProveedores = new List<SelectListItem>();

            foreach (var proveedor in proveedores)
            {
                listaProveedores.Add(new SelectListItem
                {
                    Value = proveedor.ProveedorId.ToString(),
                    Text = proveedor.Nombre
                });
            }

            return listaProveedores;
        }

        private async Task<IEnumerable<SelectListItem>> ObtenerListaCategoria()
        {
            var categorias = await repositorioCategoria.ObtenerCategoria();
            var listaCategorias = new List<SelectListItem>();

            foreach (var categoria in categorias)
            {
                listaCategorias.Add(new SelectListItem
                {
                    Value = categoria.CategoriaId.ToString(),
                    Text = categoria.Nombre
                });
            }

            return listaCategorias;
        }

        [HttpGet]
        public async Task<IActionResult> Crear()
        {
            var proveedores = await repositorioProveedor.ObtenerProveedores();
            var categoria = await repositorioCategoria.ObtenerCategoria();

            var proveedoresListItem = proveedores.Select
            (proveedor => new SelectListItem(proveedor.Nombre, proveedor.ProveedorId.ToString()));
            var categoriaListItem = categoria.Select
            (categoria => new SelectListItem(categoria.Nombre, categoria.CategoriaId.ToString()));

            var productoViewModel = new ProductosViewModel
            {
                Proveedores = proveedoresListItem,
                Categoria = categoriaListItem
            };
            return View(productoViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Crear(ProductosViewModel productoDto)
        {
            if (!ModelState.IsValid)
            {
                return View(productoDto);
            }

            var yaExisteProductos = await repositorioProductos.Existe
                (productoDto.Producto.Nombre, productoDto.Producto.ProveedorId);

            if (yaExisteProductos)
            {
                ModelState.AddModelError(nameof(productoDto.Producto.Nombre), $"El nombre " +
                    $"{productoDto.Producto.Nombre} ya existe");
                return View(productoDto);
            }


            await repositorioProductos.Crear(productoDto.Producto);

            return RedirectToAction("Index");
        }

        //public async Task<IActionResult> ExisteProducto(string nombre)
        //{
        //    var yaExisteProducto = await repositorioProductos.Existe(nombre, proveedorId);

        //    if (yaExisteProducto)
        //    {
        //        return Json($"El nombre {nombre} del producto ya existe");
        //    }

        //    return Json(true);
        //}

        [HttpGet]
        public async Task<IActionResult> Editar(int ProductoId)
        {
            var producto = await repositorioProductos.ObtenerProductoId(ProductoId);

            var proveedores = await ObtenerListaProveedores();
            var categorias = await ObtenerListaCategoria();

            var editarProducto = new EditarViewModel
            {
                ProductoId = producto.ProductoId,
                Nombre = producto.Nombre,
                Marca = producto.Marca,
                Precio = producto.Precio,
                Descripcion = producto.Descripcion,
                CategoriaId = producto.CategoriaId,
                ProveedorId = producto.ProveedorId,
                Proveedores = proveedores,
                Categorias = categorias

            };

            if (producto == null)
            {
                return RedirectToAction("Index");
            }
            return View(editarProducto);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(EditarViewModel editarProductoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            await repositorioProductos.Editar(editarProductoViewModel);

            return RedirectToAction("Index");
        }
    }
}
