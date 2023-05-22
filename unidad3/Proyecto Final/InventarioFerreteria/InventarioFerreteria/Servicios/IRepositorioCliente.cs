using InventarioFerreteria.Models;

namespace InventarioFerreteria.Servicios
{
    public interface IRepositorioCliente
    {
        Task<Cliente> Crear(Cliente cliente);
        Task<IEnumerable<Cliente>> ObtenerClientes();
        Task<Cliente> ObtenerClienteId(int clienteId);
        Task Borrar(int clienteId);
    }
}