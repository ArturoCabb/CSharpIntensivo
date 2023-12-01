using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class EjemploZip : Confiable
    {
        public override void otroMas()
        {
            int[] A = { 1, 2, 3 };
            int[] B = { 4, 5, 6 };

            var combinados = A.Zip(B);
            foreach (var combinado in combinados)
            {
                Console.WriteLine($"({combinado.First}, {combinado.Second})");
            }
            var resultado = A.Zip(B, (a, b) => a * b);
            foreach (var combinado in resultado)
            {
                Console.WriteLine(combinado);
            }
        }
    }
}
