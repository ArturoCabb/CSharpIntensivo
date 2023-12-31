﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class EjemploAny : Confiable
    {
        public override void otroMas()
        {
            var personas = new List<Persona>() {
                new Persona { Nombre = "Eduardo",Edad = 19, Soltero = true },
                new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
                new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
                new Persona { Nombre = "Valentina", Edad = 22, Soltero = false }
            };
            var existeMenor = personas.Any(p => p.Edad < 18);
            var existeMayorDe20 = personas.Any(p => p.Edad > 20);
            Console.WriteLine(existeMayorDe20);
        }
    }
}
