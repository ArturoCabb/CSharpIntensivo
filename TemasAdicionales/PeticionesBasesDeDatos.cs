using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemasAdicionales.ClientesHttp;

namespace TemasAdicionales
{
    internal class PeticionesBasesDeDatos
    {
        public static async void otroMas()
        {
            var serviceCollection = new ServiceCollection();
            Configurar(serviceCollection);
            var servicios = serviceCollection.BuildServiceProvider();
            var url = "http://localhost:5186/WeatherForecast/mayusculas";
            var httpClientFactory = servicios.GetRequiredService<IHttpClientFactory>();

            // Uso básico
            var httpClient = httpClientFactory.CreateClient();
            var respuesta = await httpClient.GetAsync(url);
            Console.WriteLine("Ejemplo 1 exitoso " + respuesta.IsSuccessStatusCode);

            // clientes nombrados
            var clienteTareas = httpClientFactory.CreateClient("tareas");
            // enviar la peticion al BaseAddress
            var respuestaTareas = await clienteTareas.GetAsync("");
            Console.WriteLine("Ejemplo 2 (tareas) exitoso:" + respuestaTareas.IsSuccessStatusCode);

            var clienteWF = httpClientFactory.CreateClient("weatherforecast");
            var respuestaWF = await clienteWF.GetAsync("mayusculas"); // WeatherForecast/mayusculas
            Console.WriteLine("Ejemplo 2 (wf) exitoso:" + respuestaWF.IsSuccessStatusCode);

            // Cliente tipado
            var clientewf = servicios.GetRequiredService<IClienteweatherForecast>();
            var listado = await clientewf.Obtener();
            Console.WriteLine("cantidad de wsf: " + listado.Count);

            //Archivos
            var rutaArchivo = @"C:\Users\acaballero\source\repos\TemasAdicionales\ejemplo.txt";
            var nombreArchivo = Path.GetFileName(rutaArchivo);
            using (var contenido = new MultipartFormDataContent())
            {
                using (var fs = File.OpenRead(rutaArchivo))
                {
                    contenido.Add(new StreamContent(fs), "archivo", nombreArchivo);
                    var respuesta1 = await clienteWF.PostAsync("posteoArchivo", contenido);
                    respuesta1.EnsureSuccessStatusCode();

                }
            }

            // Descargar archivos
            var rutaCarpeta = "../../../";
            var urlArchivo = @"http://localhost:5186/carpeta/262b9129-a5bc-433f-af03-e4b7d96b18e7.txt";
            var stream = await httpClient.GetStreamAsync(urlArchivo);
            var nombreArchivo1 = Path.GetFileName(urlArchivo);
            using (var fs = File.Create(Path.Combine(rutaCarpeta, nombreArchivo1)))
            {
                await stream.CopyToAsync(fs);
            }

            static void Configurar(ServiceCollection servicios)
            {
                // Ejemplo 1: uso basico
                servicios.AddHttpClient();
                // Ejemplo 2: clientes nombrados
                servicios.AddHttpClient("tareas", opciones =>
                {
                    opciones.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/");
                });
                servicios.AddHttpClient("weatherforecast", opciones =>
                {
                    opciones.BaseAddress = new Uri("http://localhost:5186/WeatherForecast/");
                    opciones.DefaultRequestHeaders.Add("valorPersonalizado", "Soy un cliente tipado");
                });

                // Ejemplo 3 Cliente tipados
                servicios.AddHttpClient<IClienteweatherForecast, ClienteweatherForecast>();
            }

        }
    }
}
