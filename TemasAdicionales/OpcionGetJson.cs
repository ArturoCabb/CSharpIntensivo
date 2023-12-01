using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales
{
    internal class OpcionGetJson
    {
        public static async Task otroMas()
        {
            var httpClient = new HttpClient();
            var url = "http://localhost:5186/WeatherForecast";
            var respuestaSerializada = await httpClient.GetFromJsonAsync<List<WeatherForecast>>(url);
            Console.WriteLine(respuestaSerializada?.Count);
        }
    }
}
