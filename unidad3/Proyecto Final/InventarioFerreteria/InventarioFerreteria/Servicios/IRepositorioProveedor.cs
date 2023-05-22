using InventarioFerreteria.Models;

namespace InventarioFerreteria.Servicios
{
    public interface IRepositorioProveedor
    {
        Task Borrar(int proveedorId);
        Task<Proveedor> Crear(Proveedor proveedor);
        Task<Proveedor> ObtenerProveedorId(int proveedorId);
        Task<IEnumerable<Proveedor>> ObtenerProveedores();
        Task Editar(Proveedor proveedor);
    }
}