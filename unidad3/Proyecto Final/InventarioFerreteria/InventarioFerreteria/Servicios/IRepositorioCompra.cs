using InventarioFerreteria.Models;

namespace InventarioFerreteria.Servicios
{
    public interface IRepositorioCompra
    {
        Task<Compra> Crear(Compra compra);
        Task<IEnumerable<Compra>> ObtenerCompras();
        Task<Compra> ObtenerCompraId(int compraId, int proveedorId);
    }
}