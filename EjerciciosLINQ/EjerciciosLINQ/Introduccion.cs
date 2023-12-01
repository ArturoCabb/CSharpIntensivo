using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class Introduccion : Confiable
    {
        public override void otroMas()
        {
            //int[] numeros = { 1, 2, 3, 4, 5 };
            int[] numeros = Enumerable.Range(1, 5).ToArray();
            // Sintaxis de métodos o lambda
            var numerosPares = numeros.Where(n => n % 2 == 0).ToList();
            // sintaxis de queries que utiliza programacion declarativa
            var numerosPares2 = (from n in numeros where n % 2 == 0 select n).ToList();
            // Puede utilizar funcion diferida
            var numerosPares3 = numeros.Where(n => {
                Console.WriteLine($"Evaluando si {n} es par");
                return n % 2 == 0;
            }).ToList();
            foreach (var numero in numerosPares3)
            {
                Console.WriteLine($"Sí, el {numero} es par.");
            }

            Console.WriteLine();
        }
    }
}
