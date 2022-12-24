using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingObjects
{
    public struct Coordinate
    {
        public double X;
        public double Y;
        public double Z;
        public void Print()
        {
            Console.WriteLine($"X: {X}; Y: {Y}; Z: {Z}");
        }
        public void Input(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Coordinate(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Coordinate()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
    }
}
