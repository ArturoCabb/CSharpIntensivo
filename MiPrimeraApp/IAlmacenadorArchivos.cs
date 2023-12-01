using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal interface IAlmacenadorArchivos
    {
        string Guardar(string archivo);
        void Borrar(string archivo);
        // Implementacion por defecto en interfaces
        string Editar(string urlArchivoAnterior, string archivo)
        {
            Borrar(urlArchivoAnterior);
            return Guardar(archivo);
        }
    }
}
