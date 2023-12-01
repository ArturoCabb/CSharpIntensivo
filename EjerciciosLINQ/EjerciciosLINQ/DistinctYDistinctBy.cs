using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class DistinctYDistinctBy : Confiable
    {
        public override void otroMas()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                new Persona { Nombre = "Eduardo"},
                new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
            };
            int[] numeros = { 1, 2, 3, 1, 1, 6 };
            var numerosSinRepeticiones = numeros.Distinct();
            var personasSinNombresRepetidos = personas.DistinctBy(x => x.Nombre);
            // sintaxis de queries
            var numerosSinRepeticiones2 = (from n in numeros.Distinct() select n);
            var personasSinNombresRepetidos2 = (from p in personas.DistinctBy(x => x.Nombre) select p);

            Console.WriteLine();
        }
    }
}
