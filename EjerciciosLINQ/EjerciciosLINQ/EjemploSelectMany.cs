using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class EjemploSelectMany : Confiable
    {
        public override void otroMas()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Telefonos = { "123-456", "789-852" } },
                new Persona { Nombre = "Nidia", Telefonos = { "998-478", "568-222" } },
                new Persona { Nombre = "Alejandro", Telefonos = { "712-132" } },
                new Persona { Nombre = "Valentina" }
            };
            var telefonos = personas.SelectMany(p => p.Telefonos).ToList();// Es coleccion aplanada
            var telefonosSelect = personas.Select(p => p.Telefonos).ToList();
            // Ejemplo 2: Entendiendo SelectMany con dos colecciones deiferentes
            int[] numeros = { 1, 2, 3 };
            var personasyNumeros = personas.SelectMany(p => numeros, (persona, numero) => new
            {
                Persona = persona,
                Numero = numero
            });

            foreach (var persona in personasyNumeros)
            {
                Console.WriteLine($"{persona.Persona.Nombre} - {persona.Numero}");
            }
            // Ejemplo 3: personas y telefonos
            var personasYTelefonos = personas.SelectMany(p => p.Telefonos, (persona, telefono) => new
            {
                Persona = persona,
                Telefono = telefono
            });
            foreach (var item in personasYTelefonos)
            {
                Console.WriteLine($" {item.Persona.Nombre} - {item.Telefono}");
            }

            //sintaxis de queries
            var telefonos2 = (from p in personas from t in p.Telefonos select t).ToList();
            var personasYNumeros2 = (from p in personas from n in numeros select new { Persona = p, Numero = n });

            Console.WriteLine();
        }
    }
}
