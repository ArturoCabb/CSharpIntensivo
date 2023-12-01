using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal class identificarSiHereda
    {
        public void otroMas()
        {
            var tipoBaseString = typeof(string).BaseType;
            var tipoBaseCarro = typeof(Carro).BaseType;
            Console.WriteLine($"La clase de base string es {tipoBaseString}");
            Console.WriteLine($"La clase base de carro es {tipoBaseCarro}");

            Console.WriteLine("Las interfaces de string son: ");
            foreach (var interfaz in typeof(string).GetInterfaces())
            {
                Console.WriteLine("- " + interfaz);
            }

            // Si un tipo hereda de una interfaz o clase
            var tipoString = typeof(string);
            var tipoIEnumerable = typeof(IEnumerable);
            Console.WriteLine("¿String hereda de IEnumerable?" + tipoString.IsAssignableTo(tipoIEnumerable));
            Console.WriteLine("¿Es lo inverso de arriba?" + tipoIEnumerable.IsAssignableFrom(tipoString));

            Console.WriteLine("¿Carro hereda de vehículo? " + typeof(Carro).IsAssignableTo(typeof(Vehiculo)));
            Console.WriteLine("¿Carro hereda de IEnumerable? " + typeof(Carro).IsAssignableTo(tipoIEnumerable));
        }
    }
}
