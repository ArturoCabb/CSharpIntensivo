﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class CountYLongCount : Confiable
    {
        public override void otroMas()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo", Soltero = true },
                new Persona { Nombre = "Nidia", Soltero = true },
                new Persona { Nombre = "Alejandro", Soltero = true },
                new Persona { Nombre = "Valentina", Soltero = false }
            };
            Console.WriteLine($"La cantidad de personas es {personas.Count}");
            Console.WriteLine($"La cantidad de personas solteras es {personas.Count(p => p.Soltero)}");
            Console.WriteLine($"Int max = {int.MaxValue.ToString("N")}");
            // sintaxis de queries
            var conteoSolteros = (from p in personas where p.Soltero select p).Count();
            Console.WriteLine(conteoSolteros);
        }
    }
}
