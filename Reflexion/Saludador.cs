using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal partial class Saludador
    {
        static public void Saludar(string nombre)
        {
            SaludarGenerador(nombre);
        }
        static partial void SaludarGenerador(string nombre);
    }
}
