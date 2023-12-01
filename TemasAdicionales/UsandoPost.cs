﻿using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace TemasAdicionales
{
    internal class UsandoPost
    {
        public static async Task otroMasAsync()
        {
            var httpClient = new HttpClient();
            var url = "http://localhost:5186/WeatherForecast";
            // usando PostAsJsonAsync
            var wf = new WeatherForecast()
            {
                Date = DateOnly.FromDateTime(DateTime.Now),
                Summary = "Que calor!!",
                TemperatureC = 30,
            };

            var respuesta = await httpClient.PostAsJsonAsync(url, wf);
            if (respuesta.IsSuccessStatusCode)
            {
                var cuerpo = await respuesta.Content.ReadAsStringAsync();
                Console.WriteLine("El cuerpo de la respuesta es " + cuerpo);
            }

            // usando PostAsync
            var temperaturaSerializada = JsonConvert.SerializeObject(wf);
            var stringContent = new StringContent(temperaturaSerializada, Encoding.UTF8, "application/json");
            var respuesta2 = await httpClient.PostAsync(url, stringContent);
            if (respuesta2.IsSuccessStatusCode)
            {
                var cuerpo = await respuesta2.Content.ReadAsStringAsync();
                Console.WriteLine("El cuerpo de la respuesta es " + cuerpo);
            }
        }
    }
}
