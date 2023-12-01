using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class SingleYSingleOrDefault : Confiable
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
            var personasMayorDe60 = personas.Single(p => p.Edad > 60);
            try
            {
                var personaMayorA100 = personas.Single(p => p.Edad > 100);
                var personaMayorA100_2 = personas.SingleOrDefault(p => p.Edad > 100);
            }
            catch (Exception)
            {

                Console.WriteLine("Hubo un error, arreglo vacio");
            }
            try
            {
                var personaMayorA5_2 = personas.SingleOrDefault(p => p.Edad > 5);
            }
            catch (Exception)
            {

                Console.WriteLine("Hubo un error, arreglo con más de un elemento");
            }
            // usando queries
            var personaMayorDe60_2 = (from p in personas where p.Edad > 60 select p).Single();
            Console.WriteLine();
        }
    }
}
