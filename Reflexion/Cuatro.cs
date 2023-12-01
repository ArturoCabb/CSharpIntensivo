using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal class Cuatro
    {
        public void otro()
        {
            // invocando un metodo void sin parametros
            var tipo = typeof(Utilidades);
            var utilidades = Activator.CreateInstance(tipo);
            tipo.InvokeMember("ImprimirHoraActual", System.Reflection.BindingFlags.InvokeMethod,
                binder: null, target: utilidades, args: new object[] { });

            // invocando un metodo void pasando parametros
            tipo.InvokeMember("ImprimirMensaje", System.Reflection.BindingFlags.InvokeMethod,
                binder: null, target: utilidades, args: new object[] { "usando reflexion" });

            // invocando un metodo que devuelve un valor
            var resultado = tipo.InvokeMember("ObteniendoUnValor", BindingFlags.InvokeMethod,
                binder: null, utilidades, new object[] { });

            Console.WriteLine("Obtuvimos el valor: " + resultado);

            // invocando un metodo estatico
            tipo.InvokeMember("MetodoEstatico", BindingFlags.InvokeMethod, binder: null,
                target: null, args: new object[] { });

            // invocar un metodo privado
            tipo.InvokeMember("MetodoPrivado", BindingFlags.InvokeMethod | BindingFlags.NonPublic
                | BindingFlags.Instance, binder: null, target: utilidades, args: new object[] { });
        }
    }
}
