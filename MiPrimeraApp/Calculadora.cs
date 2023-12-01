namespace MiPrimeraApp
{
    internal partial class Calculadora
    {
        internal static ResultadoDT CalcularDuploTriplo(int valor)
        {
            var resultado = new ResultadoDT();
            resultado.Valor = valor;
            resultado.Duplo = valor * 2;
            resultado.Triplo = valor * 3;
            return resultado;
        }
    }
}
