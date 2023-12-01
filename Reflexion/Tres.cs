using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal class Tres
    {
        public void eso()
        {
            // instanciando por el tipo
            var tipo = typeof(Persona);
            var personaSinNombreViaType = (Persona)Activator.CreateInstance(tipo)!;
            Console.WriteLine("Persona instanciada por el type " + personaSinNombreViaType);
            // instanciando por su nombre y assembly
            var nombreCompletoClasePersona = typeof(Persona).FullName!;
            Console.WriteLine(nombreCompletoClasePersona);
            var assemblyClasePersona = typeof(Persona).Assembly.GetName().Name;
            Console.WriteLine(assemblyClasePersona);
            var personaSinNombreViaString = Activator.CreateInstance(assemblyClasePersona,
                nombreCompletoClasePersona).Unwrap();
            Console.WriteLine(personaSinNombreViaString);
            //instanciando pasando valores al constructor
            var personaConNombreViaType = (Persona)Activator.CreateInstance(typeof(Persona),
                new object[] { "Felipe" })!;
            Console.WriteLine(personaConNombreViaType.Nombre);
        }
    }
}
