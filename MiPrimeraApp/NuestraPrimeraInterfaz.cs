using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal interface IMiInterfaz
    {
        void MiMetodo1();
        string MiMetodo2(int param1);
        void MiMetodo3();
        bool MiPropiedad1 { get; set; }
        int MiPropiedadDeSoloLectura { get; }
    }

    internal interface IMisegundaInterfaz
    {
        void MiMetodoDeLaSegundaInterfaz();
        // string marca; las interfaes no pueden contener campos de instancia
    }

    internal class MiClase : IMiInterfaz, IMisegundaInterfaz
    {
        bool IMiInterfaz.MiPropiedad1 { get; set; }

        int IMiInterfaz.MiPropiedadDeSoloLectura => 42;

        public void MiMetodo3()
        {
            throw new NotImplementedException();
        }

        void IMiInterfaz.MiMetodo1()
        {
            
        }

        string IMiInterfaz.MiMetodo2(int param1)
        {
            return "Ejemplo";
        }

        void IMisegundaInterfaz.MiMetodoDeLaSegundaInterfaz()
        {
            throw new NotImplementedException();
        }
    }

    public record MiRecord(string param1) : IMisegundaInterfaz
    {
        public void MiMetodoDeLaSegundaInterfaz()
        {
            throw new NotImplementedException();
        }
    }
    public struct MiStruct : IMisegundaInterfaz
    {
        void IMisegundaInterfaz.MiMetodoDeLaSegundaInterfaz()
        {
            throw new NotImplementedException();
        }
    }
}
