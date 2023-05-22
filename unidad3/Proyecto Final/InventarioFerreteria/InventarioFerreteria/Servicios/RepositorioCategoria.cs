using Dapper;
using InventarioFerreteria.Models;
using System.Data.SqlClient;

namespace InventarioFerreteria.Servicios
{
    public class RepositorioCategoria : IRepositorioCategoria
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;

        public RepositorioCategoria(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Categoria>> ObtenerCategoria()
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<Categoria>
                (@"SELECT CategoriaId, Nombre, Descripcion
                    FROM Categoria");
        }

        public async Task<Categoria> ObtenerCategoriaId(int categoriaId)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<Categoria>
                (@"SELECT CategoriaId, Nombre, Descripcion
                FROM Categoria
                WHERE CategoriaId = @CategoriaId",
                new { categoriaId });

        }

        public async Task<Categoria> Crear(Categoria categoria)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>
                (@"INSERT INTO Categoria
                (Nombre, Descripcion)
	             VALUES
                (@Nombre, @Descripcion);
                SELECT SCOPE_IDENTITY()",
                categoria);

            return categoria;
        }

        public async Task Editar(Categoria categoria)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync
                (@"UPDATE Categoria
                 SET Nombre = @Nombre, 
                 Descripcion = @Descripcion
                 WHERE CategoriaId = @CategoriaId", categoria);
        }

        public async Task Borrar(int CategoriaId)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("DELETE FROM Categoria WHERE CategoriaId = @CategoriaId;");
        }
    }
}
