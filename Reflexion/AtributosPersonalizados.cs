using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal static class AtributosPersonalizados
    {
        public static void otroMas()
        {
            Console.WriteLine("-- Puedes realizar las siguientes acciones --");
            foreach (var accion in Enum.GetValues<Acciones>())
            {
                var campo = typeof(Acciones).GetField(accion.ToString())!;
                //var esconder = campo.IsDefined(typeof(EsconderAttribute));
                var esconderAtributo = campo.GetCustomAttribute(typeof(EsconderAttribute));
                if (esconderAtributo is not null)
                {
                    var esconder = ((EsconderAttribute)esconderAtributo).Ocultar();
                    if (esconder)
                    {
                        continue;
                    }
                    //continue;
                }
                Console.WriteLine(accion);
            }
        }
    }
}
