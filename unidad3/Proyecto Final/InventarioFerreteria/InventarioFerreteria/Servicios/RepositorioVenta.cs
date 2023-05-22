using Dapper;
using InventarioFerreteria.Models;
using System.Data.SqlClient;

namespace InventarioFerreteria.Servicios
{
    public class RepositorioVenta : IRepositorioVenta
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;
        public RepositorioVenta(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<VentasObtener>> ObtenerVentas()
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<VentasObtener>
                (@"SELECT v.VentasId, 
                    v.Fecha,
                    v.Cantidad,
                    v.EmpleadoId,
                    v.ClienteId,
                    v.ProductoId,
                    em.Nombre AS EmpleadoNombre,
                    cl.Nombre AS ClienteNombre,
                    p.Nombre AS ProductoNombre
                    FROM Ventas AS v
                    INNER JOIN Empleados AS em ON em.EmpleadoId = v.EmpleadoId
                    INNER JOIN Clientes AS cl ON cl.ClienteId = v.ClienteId
                    INNER JOIN Productos AS p ON p.ProductoId = v.ProductoId");
        }

        public async Task<Venta> ObtenerVentaId(int ventaId)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<Venta>
                (@"SELECT VentaId, Fecha, Cantidad, ProductoId, EmpleadoId, ClienteId
                FROM Ventas
                WHERE VentaId = @VentaId",
                new { ventaId });

        }

        public async Task<Venta> Crear(Venta venta)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>
                (@"INSERT INTO Ventas
                (Fecha, Cantidad, ProductoId, EmpleadoId, ClienteId)
	             VALUES
                (@Fecha, @Cantidad, @ProductoId, @EmpleadoId, @ClienteId);
                SELECT SCOPE_IDENTITY()",
                venta);
            return venta;
        }
    }
}
