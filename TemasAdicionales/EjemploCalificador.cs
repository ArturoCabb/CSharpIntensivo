using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploArturo = TemasAdicionales.EjemploClaudia;

namespace TemasAdicionales
{
    namespace EjemploArturo
    {
        internal class EjemploCalificador
        {
            public static string Nombre = "Arturo";

            public static void Imprimir()
            {
                Console.WriteLine(Nombre);
                // Aquí se utiliza el operador calificador ::
                Console.WriteLine(EjemploArturo::EjemploCalificador.Nombre);
            }
        }
    }

    namespace EjemploClaudia
    {
        internal class EjemploCalificador
        {
            public static string Nombre = "Claudia";

            public static void Imprimir()
            {
                Console.WriteLine(Nombre);
            }
        }
    }

    public class Prubas
    {
        private class System
        {

        }
        public void Imprimir()
        {
            // No exite por la referencia
            //System.Console.WriteLine();
            // Para utilizarlo necesito
            global::System.Console.WriteLine("Hola");
        }
    }
}
