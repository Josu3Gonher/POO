using InventarioFerreteria.Models;

namespace InventarioFerreteria.Servicios
{
    public interface IRepositorioEmpleado
    {
        Task Borrar(int empleadoId);
        Task<Empleado> Crear(Empleado empleado);
        Task<Empleado> ObtenerEmpleadoId(int empleadoId);
        Task<IEnumerable<Empleado>> ObtenerEmpleados();
    }
}