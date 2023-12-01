using Microsoft.AspNetCore.Mvc;

namespace WebAPI
{
    [Route("Saludos")]
    [ApiController]
    public class SaludosController : ControllerBase
    {
        [HttpGet("{nombre}")]
        public ActionResult<string> ObtenerSaludo(string nombre)
        {
            return $"Hola, {nombre}!";
        }
    }
}
