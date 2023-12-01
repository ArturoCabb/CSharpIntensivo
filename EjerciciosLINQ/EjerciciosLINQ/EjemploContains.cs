using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class EjemploContains : Confiable
    {
        public override void otroMas()
        {
            var numeros = Enumerable.Range(1, 5);
            var estaElNumero3 = numeros.Contains(3);
            var estaElNumero20 = numeros.Contains(20);
            Console.WriteLine();
        }
    }
}
