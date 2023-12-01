using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal class OtroLugar
    {
        private readonly ControladorDePeliculas controladorDePeliculas;

        public OtroLugar(ControladorDePeliculas controladorDePeliculas)
        {
            this.controladorDePeliculas = controladorDePeliculas;
        }
        public void Procesar()
        {
            //var almacenador = new AlmaccenadorArchivosAWS();
            //var controladorDePeliculas = new ControladorDePeliculas(almacenador);
            controladorDePeliculas.GuardarPoster("Un poster.jpg");
        }
    }
}
