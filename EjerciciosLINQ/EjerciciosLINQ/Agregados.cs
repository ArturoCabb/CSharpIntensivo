using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class Agregados : Confiable
    {
        public override void otroMas()
        {
            var numeros = Enumerable.Range(1, 5);
            var resultado = numeros.Aggregate((a, b) => a * b);
            Console.WriteLine("resultado es " + resultado);

            // con una semilla
            var resultadoConValorInicial = numeros.Aggregate(10, (a, b) => a * b);
            Console.WriteLine("El resultado con el valor semilla es: " + resultadoConValorInicial);
        }
    }
}
