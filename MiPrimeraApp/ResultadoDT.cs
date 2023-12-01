namespace MiPrimeraApp
{
    internal class ResultadoDT
    {
        internal int Valor {  get; set; }
        public int Duplo { get; set; }
        public int Triplo { get; set; }

        public void Deconstruct(out int valor, out int duplo, out int triplo)
        {
            valor = Valor;
            duplo = Duplo;
            triplo = Triplo;
        }
    }
}
