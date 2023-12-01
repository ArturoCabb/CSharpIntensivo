using Entidades;
using System.Net.Http.Json;

namespace TemasAdicionales.ClientesHttp
{
    internal interface IClienteweatherForecast
    {
        Task<List<WeatherForecast>> Obtener();
    }

    internal class ClienteweatherForecast : IClienteweatherForecast
    {
        private readonly HttpClient httpClient;
        private readonly string urlBase = "http://localhost:5186/WeatherForecast/";

        public ClienteweatherForecast(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<WeatherForecast>> Obtener()
        {
            var respuesta = await httpClient.GetFromJsonAsync<List<WeatherForecast>>(urlBase);

            if (respuesta is null)
            {
                return new List<WeatherForecast>();
            }
            return respuesta;
        }
    }
}
