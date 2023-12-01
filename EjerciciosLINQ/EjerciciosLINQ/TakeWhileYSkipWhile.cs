using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class TakeWhileYSkipWhile : Confiable
    {
        public override void otroMas()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 3, 2, 1 };
            // Se detiene cuando el predicado se vuelve falso
            var resultadoTakeWhile = numeros.TakeWhile(x => x < 5).ToList();
            Console.WriteLine(resultadoTakeWhile);
            // Salta mientras sea verdadero+
            var resultadoSkipWhile = numeros.SkipWhile(x => x < 5).ToList();
            Console.WriteLine(resultadoSkipWhile);
        }
    }
}
