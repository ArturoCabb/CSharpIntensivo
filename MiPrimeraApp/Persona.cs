using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    //Para nominal
    internal record Persona
    //internal record struct Persona
    {
        // Este constructor es para el record strcut
        public Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        // Esto es un record nominal
        public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";

    }
}
