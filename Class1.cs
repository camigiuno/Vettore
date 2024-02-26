using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Vettore
    {
        public double X { get; }
        public double Y { get; }
        public Vettore(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return string.Format("{0}; {1}", X, Y);
        }
        public static Vettore Parse(string s)
        {
            string[] substring = s.Split(';');
            return new Vettore(double.Parse(substring[0]), double.Parse(substring[1]));
        }
        public static bool TryParse  (string s, out Vettore v)
        {
            double x;
            double y;
            string[] substring = s.Split(';');
            if (substring.Length > 1 && double.TryParse(substring[0], out x) && double.TryParse(substring[1], out y));
            {
                v = new Vettore( x, y);
                return true;
            }
            else
            {
                v = null;
                return false;
            }
        }
        public static Vettore operator +(Vettore v1, Vettore v2)
        {
            return new Vettore (v1.X + v2.X, v1.Y + v2.Y);
        }
        public static Vettore operator -(Vettore v1, Vettore v2)
        {
            return new Vettore (v1.X - v2.X, v1.Y - v2.Y);
        }
        public static Vettore operator *(Vettore v1, Vettore v2)
        {
            return new Vettore(v1.X * v2.X, v1.Y * v2.Y);
        }
        public static Vettore operator *(Vettore v1, double s)
        {
            return new Vettore(v1.X * s, v1.Y * s);
        }
        public static Vettore operator *(double s, Vettore v2) 
        {
            return new Vettore (s *  v2.X, s * v2.Y);
        }
        public static Vettore operator /(Vettore v1, double s)
        {
            return new Vettore(v1.X / s, v1.Y / s);
        }
        public static Vettore operator +(Vettore v)
        {
            return v;
        }
        public static Vettore operator -(Vettore v)
        {
            return new Vettore(-v.X, -v.Y);
        }
}
}


