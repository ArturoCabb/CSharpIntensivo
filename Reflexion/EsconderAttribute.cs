using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    internal class EsconderAttribute: Attribute
    {
        public EsconderAttribute() { }
        public EsconderAttribute(int añoinicio, int mesInicio, int diaInicio,
            int añoFin, int mesFin, int diaFin)
        {
            FechaInicio = new DateTime(añoinicio, mesInicio, diaInicio);
            FechaFin = new DateTime(añoFin, mesFin, diaFin);
        }
        public DateTime FechaInicio { get; }
        public DateTime FechaFin { get; }
        private bool usarRangoDeFecha = false;
        public bool Ocultar()
        {
            if (usarRangoDeFecha)
            {
                return DateTime.Now >= FechaInicio && DateTime.Now <= FechaFin;
            }
            else
            {
                return true;
            }
        }
    }
}
