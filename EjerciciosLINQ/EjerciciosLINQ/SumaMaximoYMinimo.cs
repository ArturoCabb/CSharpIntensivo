using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class SumaMaximoYMinimo : Confiable
    {
        public override void otroMas()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 19, },
                new Persona { Nombre = "Nidia", Edad = 25 },
                new Persona { Nombre = "Alejandro", Edad = 30 },
                new Persona { Nombre = "Valentina", Edad = 22 }
            };
            var numeros = Enumerable.Range(1, 5);
            Console.WriteLine($"La suma de los numeros es {numeros.Sum()}");
            Console.WriteLine($"La suma de las edades es {personas.Sum(p => p.Edad)}");
            Console.WriteLine($"La edad maxima de las personas es {personas.Max(x => x.Edad)}");
            Console.WriteLine($"La edad maxima de las personas es {personas.Min(x => x.Edad)}");

            var personaDeMayorEdad = personas.MaxBy(p => p.Edad);
            var personaDeMenorEdad = personas.MinBy(p => p.Edad);
        }
    }
}
