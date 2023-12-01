using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class EjemploConcat : Confiable
    {
        public override void otroMas()
        {
            int[] A = { 1, 2, 3 };
            int[] B = { 4, 5, 6 };
            var resultado = A.Concat(B);
            foreach (int i in resultado)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
