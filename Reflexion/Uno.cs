using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal class Uno
    {
        public void esosds()
        {
            Type tipo = typeof(int);
            int edad = 99;
            Type tipo2 = edad.GetType();
            Type tipo3 = Type.GetType("System.Int32")!;

            Console.WriteLine($"Es {tipo.Name} un arreglo? {tipo.IsArray}");
            Console.WriteLine($"El valor máximo de un entero es (sin reflexion): {int.MaxValue}");
            var valor = tipo.GetField("MaxValue")!.GetValue(default(int));
            Console.WriteLine($"El valor máximo de un entero es (con reflexion): {valor}");
        }
    }
}
