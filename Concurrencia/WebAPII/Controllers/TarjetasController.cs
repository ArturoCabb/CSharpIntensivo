using Microsoft.AspNetCore.Mvc;
using WebAPII.Helpers;

namespace WebAPII.Controllers
{
    [ApiController]
    [Route("tarjetas")]
    public class TarjetasController : ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> ProcesarTarjeta([FromBody] string tarjeta)
        {
            var valorAleatorio = RandomGen.NextDouble();
            var aprobada = valorAleatorio > 0.1;
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine($"Tarjeta {tarjeta} procesada");
            return Ok(new { Tarjeta = tarjeta, Aprobada = aprobada });
        }
    }
}
