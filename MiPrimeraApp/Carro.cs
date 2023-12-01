namespace MiPrimeraApp
{
    internal class Carro
    {
        internal Carro(): this("marca por defecto")
        {
            Console.WriteLine("Instanciando un carro");
        }
        internal Carro(string marca)
        {
            Console.WriteLine("Instanciando un carro con una marca");
            _marca = marca;
            ConteoInstancias++;
        }
        internal void Acelerar()
        {
            ConteoInstancias++;
            Acelerar(1);
        }
        private string _marca;
        internal string Marca
        {
            get { return _marca.ToUpper(); }
            //get { return _marca; }
            set { Marca = value; }
        }
        internal int Año { get; set; } = 1990;
        internal int Velocidad { get; private set; } = 20;
        private int Velocidadmaxima => 120;
        internal string NombreComercial => $"{Marca} ({Año})";
        internal void Acelerar(int incremento)
        {
            if (Velocidad >= Velocidadmaxima)
            {
                Console.WriteLine("La velocidad máxima ya ha sido alcanzada");
                return;
            } else if (Velocidad + incremento > Velocidadmaxima)
            {
                incremento = Velocidadmaxima - Velocidad;
            }
            Velocidad += incremento;
        }
        public static int ConteoInstancias {  get; set; }
        // Por convencion empieza con guion bajo
    }
}
