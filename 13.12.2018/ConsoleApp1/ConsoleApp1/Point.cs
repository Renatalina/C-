using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;

            return p;
        }
        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;

            return p;
        }

        public static Point operator -(Point p)
        {
            p.X *= -1;
            p.Y *= -1;

            return p;
            //return new Point { X = -p.X, Y = -p.Y };
        }
        //object obj = new Point();
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static bool operator ==(Point p1,Point p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Point p1,Point p2)
        {
            return !(p1 == p2);
        }

        public static bool operator >(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) > Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator <(Point p1, Point p2)
        {
            return Math.Sqrt(p1.X * p1.X + p1.Y * p1.Y) < Math.Sqrt(p2.X * p2.X + p2.Y * p2.Y);
        }

        public static bool operator true(Point p)
        {
            return p.X != 0 || p.Y != 0 ? true : false;
        }

        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0 ? true : false;
        }

        public override string ToString()
        {
            return $"Point: X = {X}, Y = {Y}";
        }
    }
}
