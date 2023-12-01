using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using WebAPII.Helpers;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace WebAPII.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SaludosController : ControllerBase
    {
        [HttpGet("saludos/{nombre}")]
        public ActionResult<string> ObtenerSaludo(string nombre)
        {
            return $"Hola, {nombre}!";
        }

        [HttpGet("saludos/delay/{nombre}")]
        public async Task<ActionResult<string>> ObtenerSaludoConDelay(string nombre)
        {
            Console.WriteLine($"Hilo antes del await: {Thread.CurrentThread.ManagedThreadId}");
            await Task.Delay(500);
            Console.WriteLine($"Hilo después del await: {Thread.CurrentThread.ManagedThreadId}");

            var esperar = RandomGen.NextDouble() * 10 + 1;
            //await Task.Delay((int)esperar * 1000);
            //OperacionVoidAsync();
            // El try no evita que colapse
            //try
            //{
            //    OperacionVoidAsync();
            //} catch (Exception ex)
            //{
            //}
            OperacionVoidSync();
            return $"Hola, {nombre}!";
        }
        private async Task OperacionTaskAsync()
        {
            await Task.Delay(1);
            throw new ApplicationException();
        }
        private void OperacionVoidSync()
        {
            throw new ApplicationException();
        }

        // Anti-Patrón: No debemos usar async void
        private async void OperacionVoidAsync()
        {
            await Task.Delay(1);
            throw new ApplicationException();
        }

        [HttpGet("saludos/adios/{nombre}")]
        public async Task<ActionResult<string>> ObtenerAdiosConDelay(string nombre)
        {
            var esperar = RandomGen.NextDouble() * 10 + 1;
            await Task.Delay((int)esperar * 1000);
            return $"Bye, {nombre}!";
        }
    }
}
