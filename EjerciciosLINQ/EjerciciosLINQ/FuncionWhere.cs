using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class FuncionWhere : Confiable
    {
        public override void otroMas()
        {
            int[] numeros = Enumerable.Range(1, 20).ToArray();

            var numerosImpares = numeros.Where(n => n % 2 == 1).ToList();
            Console.WriteLine("Los números impares son: ");
            foreach (var numero in numerosImpares)
            {
                Console.WriteLine(numero);
            }
            // En metodos
            var numerosImparesMayoresQue10 = numeros.Where(n => n % 2 == 1 && n > 10).ToList();
            // En queries
            var numerosImparesMayoresQue10_2 = from n in numeros where n % 2 == 1 && n > 10 select n;
            Console.WriteLine("Los números impares mayores que 10 son: ");
            foreach (var numero in numerosImpares)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
