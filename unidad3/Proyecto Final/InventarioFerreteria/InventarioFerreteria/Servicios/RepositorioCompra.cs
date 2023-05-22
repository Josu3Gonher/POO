using Dapper;
using InventarioFerreteria.Models;
using System.Data.SqlClient;

namespace InventarioFerreteria.Servicios
{
    public class RepositorioCompra : IRepositorioCompra
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;
        public RepositorioCompra(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Compra>> ObtenerCompras()
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<Compra>
                (@"SELECT co.ComprasId,
                    co.Fecha,
                    co.Descripcion,
                    co.Cantidad,
                    co.ProductoId,
                    co.ProveedorId,
                    p.Nombre AS ProductoNombre,
                    pr.Nombre AS ProveedorNombre
                    FROM Compras AS co
                    INNER JOIN Productos AS p ON p.ProductoId = co.ProductoId
                    INNER JOIN Proveedores AS pr ON pr.ProveedorId = co.ProveedorId
                    ");
        }

        public async Task<Compra> ObtenerCompraId(int compraId, int proveedorId)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<Compra>
                (@"SELECT CompraId, Fecha, Descripcion, Cantidad, ProductoId, ProveedorId
                FROM Compras
                WHERE CompraId = @CompraId AND ProveedorId = @ProveedorId",
                new { compraId, proveedorId });

        }

        public async Task<Compra> Crear(Compra compra)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>
                (@"INSERT INTO Compras
                (Fecha, Descripcion, Cantidad, ProductoId, ProveedorId)
	             VALUES
                (@Fecha, @Descripcion, @Cantidad, @ProductoId, @ProveedorId);
                SELECT SCOPE_IDENTITY()",
                compra);

            return compra;
        }
    }
}
