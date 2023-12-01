using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal class Persona2
    {
        public string NombreCompleto { get; set; } = null!;
        public static void Procesar(Persona p)
        {
            if (p is null)
            {
                throw new ArgumentNullException(nameof(p));
            }
        }
    }
}
