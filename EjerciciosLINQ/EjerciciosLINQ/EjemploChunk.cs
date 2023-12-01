using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosLINQ
{
    internal class EjemploChunk : Confiable
    {
        public override void otroMas()
        {
            int[] A = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var resultado = A.Chunk(3);
        }
    }
}
