using InventarioFerreteria.Models;

namespace InventarioFerreteria.Servicios
{
    public interface IRepositorioCategoria
    {
        Task Borrar(int CategoriaId);
        Task<Categoria> Crear(Categoria categoria);
        Task Editar(Categoria categoria);
        Task<IEnumerable<Categoria>> ObtenerCategoria();
        Task<Categoria> ObtenerCategoriaId(int categoriaId);
    }
}