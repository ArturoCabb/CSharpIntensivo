using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal class AlmaccenadorArchivosAWS : IAlmacenadorArchivos
    {
        public void Borrar(string archivo)
        {
            Console.WriteLine("Borrar el archivo en AWS");
        }

        public string Guardar(string archivo)
        {
            Console.WriteLine("Guardando el archivo en AWS");
            return "URL del archivo en AWS";
        }

        string Editar(string urlArchivoAnterior, string archivo)
        {
            Console.WriteLine("Nueva implementación de editar");
            return "";
        }
    }
}
