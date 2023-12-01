using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal class ControladorDePeliculas
    {
        private readonly IAlmacenadorArchivos almacenadorArchivos;

        // La inyeccion de dependencias es via el constructor
        public ControladorDePeliculas(IAlmacenadorArchivos almacenadorArchivos)
        {
            this.almacenadorArchivos = almacenadorArchivos;
        }
        // Esta es una inyeccion por metodo
        //public void GuardarPoster(string poster, IAlmacenadorArchivos almacenadorArchivos)
        public void GuardarPoster(string poster)
        {
            //var almacenadorArchivos = new AlmacenadorArchivosAzure();
            almacenadorArchivos.Guardar(poster);
        }

        public void BorrarPoster(string urlPoster)
        {
            almacenadorArchivos.Borrar(urlPoster);
        }
    }
}
