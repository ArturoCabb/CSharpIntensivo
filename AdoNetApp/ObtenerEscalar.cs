using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetApp
{
    internal class ObtenerEscalar
    {
        //public ObtenerEscalar()
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
        //                //comando.CommandType = CommandType.StoredProcedure;

        //                var cantidadDeRegistros = await comando.ExecuteScalarAsync();
        //                Console.WriteLine("Cantidad de registros: " + cantidadDeRegistros);
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
