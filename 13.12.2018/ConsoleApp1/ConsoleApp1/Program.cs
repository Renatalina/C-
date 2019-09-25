
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Point point = new Point { X = 12, Y = 23 };

            Console.WriteLine(point++); // 13 24
            Console.WriteLine(++point); // 14 25

            Console.WriteLine(point--); // 13 24
            Console.WriteLine(--point); // 12 23

            Console.WriteLine(-point);*/


            /*Point p1 = new Point { X = 20, Y = 30 };
            Point p2 = new Point { X = 10, Y = 20 };

            Vector vector = new Vector(p1, p2); // конструктор
            Vector vector1 = new Vector { X = 25, Y = 34 }; // синтаксис инициализации объектов

            Console.WriteLine($"Vector sum: {vector + vector1}");

            Console.WriteLine($"Vector sub: {vector - vector1}");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{vector} * {n} = {vector*n}");

            vector1 *= 5;

            Console.WriteLine(vector1);*/

            /*Point p1 = new Point { X = 20, Y = 30 };
            Point p2 = new Point { X = 10, Y = 20 };

            if (p1==p2)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("No equals");
            }

            Console.WriteLine($"p1 > p2: {p1 > p2}"); // true
            Console.WriteLine($"p1 < p2: {p1 < p2}"); // false*/

            Point point = new Point
            {
                X = int.Parse(Console.ReadLine()),
                Y = int.Parse(Console.ReadLine())
            };

            if (point)
            {
                Console.WriteLine("!=0");
            }
            else
            {
                Console.WriteLine("==0");
            }

            Console.ReadKey();
        }
    }
}
