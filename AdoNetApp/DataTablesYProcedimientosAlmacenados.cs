﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetApp
{
    internal class DataTablesYProcedimientosAlmacenados
    {
        //public async Task EXPERAR()
        //{
        //    using IHost host = Host.CreateDefaultBuilder(args).Build();
        //    var configuración = host.Services.GetService<IConfiguration>();
        //    var cadenaConexión = configuración.GetConnectionString("cadenaDeConexion");

        //    Console.WriteLine("Escribe el nombre de la persona a ingresar a la BD: ");
        //    //var nombre = Console.ReadLine();
        //    try
        //    {
        //        using (SqlConnection conexión = new SqlConnection(cadenaConexión))
        //        {
        //            conexión.Open();
        //            Console.WriteLine("Conexion abierta");
        //            //var query = "Personas_Insertar"; // Esto es para un procedimiento almacenado
        //            var query = "Personas_Leer";
        //            using (SqlCommand comando = new SqlCommand(query, conexión))
        //            {
        //                comando.CommandType = CommandType.StoredProcedure;
        //                using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
        //                {
        //                    var dt = new DataTable();
        //                    adaptador.Fill(dt);

        //                    foreach (DataRow fila in dt.Rows)
        //                    {
        //                        Console.WriteLine($"{fila["Id"]} | {fila["Nombre"]}");
        //                    }
        //                }
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
