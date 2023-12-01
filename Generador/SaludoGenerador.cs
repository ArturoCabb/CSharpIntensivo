using Microsoft.CodeAnalysis;
using System;

namespace Generador
{
    [Generator]
    public class SaludoGenerador : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
            string codigoFuente = @"namespace Reflexion
{
    internal partial class Saludador
    {
        static partial void SaludarGenerador(string nombre)
        {
            Console.WriteLine($""El generador 2 dice: Hola, {nombre}. ¿Cómo estás?"");
        }
    }
}";
            context.AddSource("Saludador.g.cs", codigoFuente);
        }

        public void Initialize(GeneratorInitializationContext context)
        {
            
        }
    }
}
