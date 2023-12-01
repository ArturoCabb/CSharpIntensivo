using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales
{
    internal class RecibenParametros
    {
        public static async Task otroMas()
        {
            var httpClient = new HttpClient();
            var url = "http://localhost:5186/WeatherForecast/mayusculas";

            // sin mandar cabecera
            Console.WriteLine("Ejemplo 1: ");
            Console.WriteLine(await httpClient.GetStringAsync(url));
            // mandar una cabecera personalizada una vez
            using (var peticionHTTP = new HttpRequestMessage(HttpMethod.Get, url))
            {
                peticionHTTP.Headers.Add("valorpersonalizado", "Soy claudia");
                var respuesta = await httpClient.SendAsync(peticionHTTP);
                Console.WriteLine("Ejemplo 2:");
                Console.WriteLine(await respuesta.Content.ReadAsStringAsync());
            }
            // Mandando la cabecera siempre
            Console.WriteLine("Ejemplo 3:");
            httpClient.DefaultRequestHeaders.Add("valorPersonalizado", "Soy Alex");
            Console.WriteLine(await httpClient.GetStringAsync(url));
            Console.WriteLine(await httpClient.GetStringAsync(url));
            httpClient.DefaultRequestHeaders.Clear();
            Console.WriteLine(await httpClient.GetStringAsync(url));
        }
    }
}
