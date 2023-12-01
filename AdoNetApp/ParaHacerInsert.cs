using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Data;

namespace AdoNetApp
{
    internal class ParaHacerInsert
    {
        //public async void ParaInsert()
        //{
        //    using IHost host = Host.CreateDefaultBuilder(args).Build();
        //    var configuración = host.Services.GetService<IConfiguration>();
        //    var cadenaConexión = configuración.GetConnectionString("cadenaDeConexion");

        //    Console.WriteLine("Escribe el nombre de la persona a ingresar a la BD: ");
        //    var nombre = Console.ReadLine();
        //    try
        //    {
        //        using (SqlConnection conexión = new SqlConnection(cadenaConexión))
        //        {
        //            conexión.Open();
        //            Console.WriteLine("Conexion abierta");
        //            //var query = "Personas_Insertar"; // Esto es para un procedimiento almacenado
        //            var query = "SELECT COUNT(*) FROM Personas";
        //            using (SqlCommand comando = new SqlCommand(query, conexión))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;
        //                comando.Parameters.Add(new SqlParameter("@nombre", nombre));
        //                var parametroId = new SqlParameter
        //                {
        //                    ParameterName = "@id",
        //                    Direction = ParameterDirection.Output,
        //                    DbType = DbType.Int32
        //                };
        //                comando.Parameters.Add(parametroId);
        //                var filasAfectadas = await comando.ExecuteNonQueryAsync();
        //                //Console.WriteLine("Filas afectadas: " + filasAfectadas);

        //                var id = (int)parametroId.Value;
        //                Console.WriteLine("Id de la persona: " + id);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("No pudimos abrir la conexión");
        //        Console.WriteLine(ex.Message);
        //        throw;
        //    }

        //    Console.WriteLine("Fin");

        //    await host.RunAsync();
        //}
    }
}
