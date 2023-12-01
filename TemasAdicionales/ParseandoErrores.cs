using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales
{
    internal class ParseandoErrores
    {
        public static async Task otroMas()
        {
            var httpClient = new HttpClient();
            var url = "http://localhost:5186/WeatherForecast";

            var wf = new WeatherForecast()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                TemperatureC = -90,
                Summary = "Hace chingo de frío"
            };

            var wfserializado = JsonConvert.SerializeObject(wf);
            var stringContent = new StringContent(wfserializado, Encoding.UTF8, "application/json");
            var respuesta = await httpClient.PostAsync(url, stringContent);

            if (respuesta.IsSuccessStatusCode)
            {
                Console.WriteLine("Todo bien");
            }
            else if (respuesta.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                var cuerpo = await respuesta.Content.ReadAsStringAsync();
                var camposCamposConErrores = Utilidades.ExtraerErroresDelWebAPI(cuerpo);
                foreach (var campoConErrores in camposCamposConErrores)
                {
                    Console.WriteLine($"- {campoConErrores.Key}");
                    foreach (var error in campoConErrores.Value)
                    {
                        Console.WriteLine($"    {error}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Otro tipo de situación");
            }
        }
    }
}
