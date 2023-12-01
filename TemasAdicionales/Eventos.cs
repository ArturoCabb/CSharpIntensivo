using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TemasAdicionales
{
    internal class Eventos
    {
        public static void otroMas()
        {
            // Eventos
            var miTimer = new System.Timers.Timer(1000);
            miTimer.Elapsed += ImprimirHoraActual;
            // Aquí me suscribo al evento
            miTimer.Start();
            Console.ReadLine();
            Console.WriteLine("Ahora, vamos a imprimir mi nombre también: ");
            miTimer.Elapsed += ImprimirMiNombre;
            Console.ReadLine();
            Console.WriteLine("Ya no vamos a imprimir mi nombre: ");
            miTimer.Elapsed -= ImprimirMiNombre;
            Console.ReadLine();
            Console.WriteLine("Fin");

            void ImprimirMiNombre(object? sender, ElapsedEventArgs e)
            {
                Console.WriteLine("Felipe");
            }


            void ImprimirHoraActual(object? sender, System.Timers.ElapsedEventArgs e)
            {
                Console.WriteLine(DateTime.Now);
            }
        }
    }
}
