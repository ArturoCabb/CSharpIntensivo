using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales
{
    internal class ClienteFactory
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

            static void Configurar(ServiceCollection servicios)
            {
                servicios.AddHttpClient();
            }
        }
    }
}
