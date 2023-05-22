using InventarioFerreteria.Models;

namespace InventarioFerreteria.Servicios
{
    public interface IRepositorioProductos
    {
        Task ActualizarProducto(Producto producto);
        Task Crear(Producto productos);
        Task Editar(EditarViewModel producto);
        Task<bool> Existe(string nombre, int proveedorId);
        Task<IEnumerable<ObtenerProductos>> Obtener();
        Task<Producto> ObtenerProductoId(int productoId);
    }
}