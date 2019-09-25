using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal struct Dimension
    {
        private double _height;
        public double width;

        //public Dimension() { } //Error

        public Dimension(double h, double w)
        {
            _height = h;
            width = w;
        }

        public void Print()
        {
            Console.WriteLine($"Height: {_height}, Width: {width}");
        }
    }
}
