using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class SkipYSkipLast : Confiable
    {
        public override void otroMas()
        {
            var numeros = Enumerable.Range(1, 100);
            var primeros10Numeros = numeros.Take(10).ToList();
            var segundoLoteDe10 = numeros.Skip(10).Take(10).ToList();
            var ultimos10Numeros = numeros.TakeLast(10).ToList();
            var penultimoLote = numeros.SkipLast(10).TakeLast(10).ToList();
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"Pagina {i}");
                var paginado = numeros.Paginar(i, 10);
                foreach (var numero in paginado)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }

    public static class IEnumerableExtension
    {
        public static IEnumerable<T> Paginar<T>(this IEnumerable<T> coleccion, int pagina, int tamañoLote)
        {
            return coleccion.Skip((pagina - 1) * tamañoLote).Take(tamañoLote);
        }
    }
}
