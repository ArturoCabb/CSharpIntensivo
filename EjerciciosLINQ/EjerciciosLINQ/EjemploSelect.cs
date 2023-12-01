using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class EjemploSelect : Confiable
    {
        public override void otroMas()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                new Persona { Nombre = "Valentina", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false }
            };
            var nombres = personas.Select(p => p.Nombre).ToList();
            var nombresYEdaddes = personas.Select(p => new {Nombre = p.Nombre, Edad = p.Edad,}).ToList();
            var nombresYEdadesDTO = personas.Select(p => new PersonaDTO { Nombre = p.Nombre, Edad = p.Edad }).ToList();
            var numeros = Enumerable.Range(1,5).ToList();
            var numerosDuplicados = numeros.Select(n => 2*n).ToList(); // El 2*n hace una transformacion, conversion
            var personasConIndice = personas.Select((p, indice) => new {Persona = p, Indice = indice + 1}).ToList();
            foreach (var person in personasConIndice)
            {
                Console.WriteLine($"{person.Indice}) {person.Persona.Nombre}");
            }
            // usando queries
            var nombres2 = (from p in personas select p.Nombre).ToList();
            var nombresYEdaddes2 = (from p in personas select new {Nombre = p.Nombre, Edad = p.Edad}).ToList();
            var numerosDuplicados2 = (from n in numeros select 2*n);
            // no se puede hacer indice con sintaxis de queries

            Console.WriteLine();
        }
    }
}
