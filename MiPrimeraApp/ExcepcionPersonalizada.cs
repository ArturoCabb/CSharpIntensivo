using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal class ExcepcionPersonalizada : Exception
    {
        public ExcepcionPersonalizada(TipoError tipoError): base("Esta es una excepcion personaliada")
        {
            TipoError = tipoError;
        }
        public ExcepcionPersonalizada(TipoError tipoError, string? message) : base(message)
        {
            TipoError = tipoError;
        }

        public TipoError TipoError { get; }
    }

    internal enum TipoError
    {
        ErrorDelCliente,
        ErrorDelServidor,
        RecursoNoEncontrado
    }
}
