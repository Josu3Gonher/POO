using Dapper;
using InventarioFerreteria.Models;
using System.Data.SqlClient;

namespace InventarioFerreteria.Servicios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;
        public RepositorioCliente(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Cliente>> ObtenerClientes()
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<Cliente>
                (@"SELECT ClienteId, Nombre, Apellido, Direccion, DNI, Telefono
                    FROM Clientes");
        }

        public async Task<Cliente> ObtenerClienteId(int clienteId)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<Cliente>
                (@"SELECT ClienteId, Nombre, Apellido, Direccion, DNI, Telefono
                FROM Clientes
                WHERE ClienteId = @ClienteId",
                new { clienteId });

        }

        public async Task<Cliente> Crear(Cliente cliente)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>
                (@"INSERT INTO Clientes
                (Nombre, Apellido, Direccion, DNI, Telefono)
	             VALUES
                (@Nombre, @Apellido, @Direccion, @DNI, @Telefono);
                SELECT SCOPE_IDENTITY()",
                cliente);

            return cliente;
        }

        public async Task Borrar(int clienteId)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("DELETE FROM Clientes WHERE ClienteId = @ClienteId;",
                new { clienteId });
        }
    }
}
