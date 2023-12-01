using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class FiltrandoporTipoOfType : Confiable
    {
        public override void otroMas()
        {
            var listado = new List<object>() { "Arturo", 1, 2, "Claudia", true };
            var strings = listado.OfType<string>();
            var numeros = listado.OfType<int>();
            // sintaxis de queries
            var strings2 = (from s in listado.OfType<string>() select s);
            // usando herencia
            var listadoAnimales = new List<Animal>()
            {
                new Perro(){Nombre="Firulais"},
                new Gato(){Nombre="Felix"}
            };
            var perros = listadoAnimales.OfType<Perro>();
            Console.WriteLine();
        }
        public abstract class Animal
        {
            public abstract string? Nombre { get; set; }
        }

        public class Perro : Animal
        {
            public override string? Nombre { get; set; }
        }

        public class Gato : Animal
        {
            public override string? Nombre { get; set; }
        }
    }
}
