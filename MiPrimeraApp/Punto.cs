using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimeraApp
{
    internal struct Punto
    {
        public Punto()
        {
            
        }

        public Punto(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Distancia(Punto b) => Math.Sqrt(Math.Pow(b.X - X, 2) + Math.Pow(b.Y - Y, 2));

        public int X { get; set; }
        public int Y { get; set; }

        // Cuando sobrecargo el == tambien tengo que hacerlo con !=
        public static bool operator ==(Punto p1, Punto p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }
        public static bool operator !=(Punto p1, Punto p2)
        {
            return !(p1 == p2);
        }
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return (X, Y).GetHashCode();
        }
    }
}
