using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class EjemploJoin : Confiable
    {
        public override void otroMas()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", EmpresaId = 1, },
                new Persona { Nombre = "Nidia",  EmpresaId = 1 },
                new Persona { Nombre = "Alejandro", EmpresaId = 3 },
                new Persona { Nombre = "Valentina",  EmpresaId = 2 },
                new Persona { Nombre = "Roberto",  EmpresaId = 3 },
                new Persona { Nombre = "Eugenia"},
                new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
            };

            var empresas = new List<Empresa>() {
                new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
                new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
                new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"}
            };
            var personasYEmpresas = personas.Join(empresas, p => p.EmpresaId, e => e.Id, (persona, empresa) => new
            {
                Persona = persona,
                Empresa = empresa
            });
            // sintaxis de queries
            var personasYEmpresas2 = (from p in personas join e in empresas on p.EmpresaId equals e.Id select new { Persona = p, Empresa = e });
            foreach (var item in personasYEmpresas)
            {
                Console.WriteLine($"{item.Persona.Nombre} trabaja en {item.Empresa.Nombre}");
            }
        }
    }
}
