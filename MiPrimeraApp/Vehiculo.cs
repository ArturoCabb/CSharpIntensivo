namespace MiPrimeraApp
{
    // ABSTRACT Esto hace que no se pueda instanciar la clase
    // El abstract hace que todos estén obligados a implementar lo que la clase abstracta contiene
    internal abstract class Vehículo
    {
        public Vehículo()
        {
            
        }

        // Cuando el constructor tiene algo las clases heredaras deben invocar al constructor
        public Vehículo(string marca)
        {
            Marca = marca;
        }

        public string? Marca { get; set; }
        public int AñoCreación { get; set; }
        public int Velocidad { get; private set; }
        public abstract int VelocidadMáxima { get; }

        // Virtual me permite hacer cambios a una función ya creada
        public virtual void DarReversa()
        {
            Console.WriteLine("Dando reversa");
        }

        public abstract void SonarClaxon();

        internal void Acelerar(int incremento = 1)
        {
            if (Velocidad >= VelocidadMáxima)
            {
                Console.WriteLine("la velocidad máxima ya ha sido alcanzada");
                return;
            }
            else if (Velocidad + incremento > VelocidadMáxima)
            {
                incremento = VelocidadMáxima - Velocidad;
            }
            Velocidad += incremento;
        }
    }

    internal class Carro1 : Vehículo
    {
        public Carro1()
        {
        }

        public Carro1(string marca) : base(marca)
        {
        }

        public override int VelocidadMáxima => 80;

        public void EncenderRadio()
        {
            Console.WriteLine("Encendiendo la radio");
        }

        // Esto hace que mi funcion tenga que ser implementada
        // tal cual ya está escrita y no permite modificación
        public sealed override void SonarClaxon()
        {
            Console.WriteLine("BIP BIP");
        }

        public override string ToString()
        {
            return "Carro con marca " + Marca;
        }
    }

    internal class SonataGris : Carro1
    {
        public SonataGris(string marca) : base(marca)
        {
        }
    }

    internal class Camión : Vehículo
    {
        public override int VelocidadMáxima => 70;

        public override void DarReversa()
        {
            base.DarReversa();
            Console.WriteLine("BEEP! BEEP! BEEP!");
        }

        public override void SonarClaxon()
        {
            Console.WriteLine("PON POOOON");
        }
    }

    internal class Bicicleta : Vehículo
    {
        public override int VelocidadMáxima => 20;

        public override void SonarClaxon()
        {
            Console.WriteLine("TIRIN");
        }
    }
}
