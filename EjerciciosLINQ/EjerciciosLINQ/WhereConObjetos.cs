using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class WhereConObjetos : Confiable
    {
        public override void otroMas()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
                new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
                new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false }
            };

            // sintaxis de método
            var personaDe25AñosOMenos = personas.Where(p => p.Edad <= 25).ToList();
            foreach (var persona in personaDe25AñosOMenos)
            {
                Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años.");
            }

            var solteros = personas.Where((p) => p.Soltero).ToList();
            foreach (var persona in solteros)
            {
                Console.WriteLine($"{persona.Nombre} es solter@");
            }

            var personasConMenosDeTresMeses = personas.Where((p) => p.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3)).ToList();
            foreach (var persona in personasConMenosDeTresMeses)
            {
                Console.WriteLine($"{persona.Nombre} tiene menos de 3 meses en la empresa.");
            }

            // Sintaxis de quieries
            var personasConMenosDeTresMeses_2 = from p in personas where p.FechaIngresoALaEmpresa >= DateTime.Now.AddMonths(-3) select p;
            foreach (var persona in personasConMenosDeTresMeses_2)
            {
                Console.WriteLine($"{persona.Nombre} tiene menos de 3 meses en la empresa.");
            }

            Console.WriteLine();
        }
    }
}
