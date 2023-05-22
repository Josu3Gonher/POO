using Dapper;
using InventarioFerreteria.Models;
using System.Data.SqlClient;

namespace InventarioFerreteria.Servicios
{
    public class RepositorioProveedor : IRepositorioProveedor
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;

        public RepositorioProveedor(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Proveedor>> ObtenerProveedores()
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<Proveedor>
                (@"SELECT ProveedorId, Nombre, Telefono
                    FROM Proveedores");
        }

        public async Task<Proveedor> ObtenerProveedorId(int proveedorId)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<Proveedor>
                (@"SELECT ProveedorId, Nombre, Telefono
                    FROM Proveedores
                    WHERE ProveedorId = @ProveedorId",
                 new { proveedorId });
        }

        public async Task<Proveedor> Crear(Proveedor proveedor)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>
                (@"INSERT INTO Proveedores
                (Nombre, Telefono)
	             VALUES
                (@Nombre, @Telefono);
                SELECT SCOPE_IDENTITY()",
                proveedor);

            return proveedor;
        }

        public async Task Editar(Proveedor proveedor)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync
                (@"UPDATE Proveedores
                 SET Nombre = @Nombre, 
                 Telefono = @Telefono
                 WHERE ProveedorId = @ProveedorId", proveedor);
        }

        public async Task Borrar(int proveedorId)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("DELETE FROM Proveedores WHERE ProveedorId = @ProveedorId;",
                new { proveedorId });
        }
    }
}
