using InventarioFerreteria.Models;

namespace InventarioFerreteria.Servicios
{
    public interface IRepositorioVenta
    {
        Task<Venta> Crear(Venta venta);
        Task<IEnumerable<VentasObtener>> ObtenerVentas();
        Task<Venta> ObtenerVentaId(int ventaId);
    }
}