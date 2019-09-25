using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vector
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Vector() { }

        public Vector(Point begin, Point end)
        {
            X = end.X - begin.X;
            Y = end.Y - begin.Y;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            Vector vector = new Vector
            {
                X = v1.X + v2.X,
                Y = v1.Y + v2.Y
            };

            return vector;
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            Vector vector = new Vector
            {
                X = v1.X - v2.X,
                Y = v1.Y - v2.Y
            };

            return vector;
        }

        public static Vector operator *(Vector v, int n)
        {
            v.X *= n; // v.X = v.X * n 
            v.Y *= n;
            return v;
        }
        public override string ToString()
        {
            return $"Vector: X = {X}, Y = {Y}";
        }
    }
}
