using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Reflexion
{
    internal static class EjemploAtributos
    {
        public static void Ejercicio()
        {
            var persona = new Persona();
            persona.Edad = 17;
            persona.OtoNumero = 7;
            //var esValido = ValidarPersona(persona);
            var errores = ValidarObjeto(persona);
            if (errores.Any())
            {
                Console.WriteLine("La persona no tiene los datos correctos");
                foreach (var error in errores)
                {
                    Console.WriteLine($"- Propiedad: {error.Propiedad}; Mensaje: {error.MensajeDeError}");
                }
                return;
            }
            Console.WriteLine("La edad de la persona es: " + persona.Edad);
            Console.WriteLine("Fin");
        }

        static bool ValidarPersona(Persona p)
        {
            var tipo = p.GetType();
            var propiedadEdad = tipo.GetProperty("Edad");
            if (propiedadEdad.IsDefined(typeof(RangeAttribute)))
            {
                var atributoRange = (RangeAttribute)Attribute
                    .GetCustomAttribute(propiedadEdad, typeof(RangeAttribute))!;
                return p.Edad >= (int)atributoRange.Minimum && p.Edad <=(int)atributoRange.Maximum;
            }
            return true;
        }

        static IEnumerable<ErrorValidacion> ValidarObjeto(object obj)
        {
            var t = obj.GetType();
            var propiedades = t.GetProperties();
            var resultado = new List<ErrorValidacion>();

            foreach (var propiedad in propiedades)
            {
                if (propiedad.IsDefined(typeof(RangeAttribute)))
                {
                    var atributoRango = (RangeAttribute)Attribute
                        .GetCustomAttribute(propiedad, typeof(RangeAttribute))!;
                    var valor = (int)propiedad.GetValue(obj)!;
                    var minimo = (int)atributoRango.Minimum;
                    var maximo = (int)atributoRango.Maximum;
                    var esValido = valor >= minimo && valor <= maximo;
                    if (!esValido)
                    {
                        resultado.Add(new ErrorValidacion
                        {
                            Propiedad = propiedad.Name,
                            MensajeDeError = $"El valor debe de estar entre {minimo} y {maximo}"
                        });
                    }
                }
            }
            return resultado;
        }
    }
}
