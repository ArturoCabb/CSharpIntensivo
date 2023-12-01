using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class TakeYTakeLast : Confiable
    {
        public override void otroMas()
        {
            var numeros = Enumerable.Range(1, 100);
            var primeros10Numeros = numeros.Take(10).ToList();
            var ultimosNumeros = numeros.TakeLast(10).ToList();
            // Sintaxis de queries
            var primeros10Numeros2 = (from n in numeros select n).Take(10);
            Console.WriteLine();
        }
    }
}
