using Dapper;
using InventarioFerreteria.Models;
using System.Data.SqlClient;

namespace InventarioFerreteria.Servicios
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly IConfiguration configuration;
        private readonly string connectionString;
        public RepositorioEmpleado(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<IEnumerable<Empleado>> ObtenerEmpleados()
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryAsync<Empleado>
                (@"SELECT EmpleadoId, Nombre, CodigoEmpleado, Cargo
                    FROM Empleados");
        }

        public async Task<Empleado> ObtenerEmpleadoId(int empleadoId)
        {
            using var connection = new SqlConnection(connectionString);
            return await connection.QueryFirstOrDefaultAsync<Empleado>
                (@"SELECT EmpleadoId, Nombre, CodigoEmpleado, Cargo
                      FROM Empleados
                      WHERE EmpleadoId = @EmpleadoId",
                  new { empleadoId });

        }

        public async Task<Empleado> Crear(Empleado empleado)
        {
            using var connection = new SqlConnection(connectionString);
            var id = await connection.QuerySingleAsync<int>
                (@"INSERT INTO Empleados
                     (Nombre, CodigoEmpleado, Cargo)
	                 VALUES
                     (@Nombre, @CodigoEmpleado, @Cargo);
                     SELECT SCOPE_IDENTITY()",
                 empleado);

            return empleado;
        }
        public async Task Borrar(int empleadoId)
        {
            using var connection = new SqlConnection(connectionString);
            await connection.ExecuteAsync("DELETE FROM Empleados WHERE EmpleadoId = @EmpleadoId;",
                new { empleadoId });
        }
    }
}
