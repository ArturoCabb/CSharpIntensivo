using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal class AlmacenadorArchivosAzure: IAlmacenadorArchivos
    {
        public void Borrar(string archivo)
        {
            Console.WriteLine("Borrar el archivo en Azure");
        }

        public string Guardar(string archivo)
        {
            Console.WriteLine("Guardando el archivo");
            return "URL del archivo en Azure";
        }
    }
}
