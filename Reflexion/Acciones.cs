using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    internal enum Acciones
    {
        EscribirTXT = 1,
        [Esconder]
        EscribirXML = 2,
        [Esconder(2022, 8, 18, 2022, 9, 28)]
        EscribirJSON = 3,
    }
}
