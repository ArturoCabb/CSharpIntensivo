using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal static class ExpandoObjeto
    {
        public static void otroMas()
        {
            dynamic objetoExpandible = new ExpandoObject();
            objetoExpandible.Nombre = "Felipe";
            objetoExpandible.Apellido = "Caballero";
            Console.WriteLine(objetoExpandible.Nombre);
            Console.WriteLine(objetoExpandible.Apellido);
            objetoExpandible.Sumar = new Func<int, int, int>((int a, int b) => a + b);
            Console.WriteLine(objetoExpandible.Sumar(1, 2));
            var diccionario = (IDictionary<string, object>)objetoExpandible;
            Console.WriteLine(diccionario["Nombre"]);
            foreach (var llave in diccionario.Keys)
            {
                Console.WriteLine(llave);
            }
            diccionario.Remove("Apellido");
        }
    }
}
