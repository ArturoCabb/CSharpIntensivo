using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales
{
    internal class ClientesNombrados
    {
        public static async Task otroMas()
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

            static void Configurar(ServiceCollection servicios)
            {
                // Ejemplo 1
                servicios.AddHttpClient();
                // Ejemplo 2
                servicios.AddHttpClient("tareas", opciones =>
                {
                    opciones.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/todos/");
                });
                servicios.AddHttpClient("weatherforecast", opciones =>
                {
                    opciones.BaseAddress = new Uri("http://localhost:5186/WeatherForecast/");
                    opciones.DefaultRequestHeaders.Add("valorPersonalizado", "Soy un cliente tipado");
                });

            }
        }
    }
}
