using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Arturo = TemasAdicionales.Ejemplos.Arturo;
using Claudia = TemasAdicionales.Ejemplos.Claudia;

namespace TemasAdicionales
{
    internal class Alias
    {
        public static void otromas()
        {
            Console.WriteLine(Arturo.EjemploAlias.Nombre);
            Console.WriteLine(Claudia.EjemploAlias.Nombre);
        }
    }
}
