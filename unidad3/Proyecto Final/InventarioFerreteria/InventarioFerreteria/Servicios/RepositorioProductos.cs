using Dapper;
using InventarioFerreteria.Models;
using System.Data.SqlClient;

namespace InventarioFerreteria.Servicios
{
    public class RepositorioProductos : IRepositorioProductos
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;
        public RepositorioProductos(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<ObtenerProductos>> Obtener()
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<ObtenerProductos>
                (@"SELECT p.ProductoId,
                    p.Nombre,
                    p.Precio,
                    p.Marca,
                    p.Descripcion,
                    p.CategoriaId,
                    p.ProveedorId,
                    ca.Nombre AS CategoriaNombre,
                    po.Nombre AS ProveedorNombre

                    FROM Productos AS p
                    INNER JOIN Categoria AS ca ON ca.CategoriaId = p.CategoriaId
                    INNER JOIN Proveedores AS po ON po.ProveedorId = p.ProveedorId");
        }

        public async Task<Producto> ObtenerProductoId(int productoId)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<Producto>(
                @"SELECT ProductoId, Nombre, Marca, Precio, Descripcion, CategoriaId, ProveedorId
                FROM Productos
                WHERE ProductoId = @ProductoId",
                new { productoId });
        }

        public async Task Crear(Producto productos)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>
                (@"INSERT INTO Productos
                (Nombre, Marca, Precio, ProveedorId, CategoriaId)
	             VALUES
                (@Nombre, @Marca, @Precio, @ProveedorId, @CategoriaId);
                SELECT SCOPE_IDENTITY()",
                productos);
        }

        public async Task<bool> Existe(string nombre, int proveedorId)
        {
            using var connection = new SqlConnection(connectionString);
            var existe = await connection.QueryFirstOrDefaultAsync<int>
                (@"SELECT 1
                FROM Productos
                WHERE Nombre = @Nombre AND ProveedorId = @ProveedorId",
                new { nombre, proveedorId });

            return existe == 1;

        }

        public async Task Editar(EditarViewModel producto)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync
                (@"UPDATE Productos
                 SET Nombre = @Nombre,
                  Marca = @Marca, 
                  Precio = @Precio, 
                  Descripcion = @Descripcion,
                  CategoriaId = @CategoriaId,
                  ProveedorId = @ProveedorId
                 WHERE ProductoId = @ProductoId", producto);
        }
        public async Task ActualizarProducto(Producto producto)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync(@"UPDATE Productos
                                            SET
                                            Nombre = @Nombre,
                                            Marca = @Marca,
                                            Precio = @Precio,
                                            Descripcion = @Descripcion,
                                            CategoriaId = @CategoriaId,
                                            ProveedorId = @ProveedorId
                                            WHERE ProductoId = @ProductoId",
                                            new
                                            {
                                                producto.Nombre,
                                                producto.Marca,
                                                producto.Precio,
                                                producto.Descripcion,
                                                producto.CategoriaId,
                                                producto.ProveedorId,
                                                producto.ProductoId
                                            });
        }
    }
}
