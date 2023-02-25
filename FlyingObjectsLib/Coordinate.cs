using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingObjects
{
    public struct Coordinate
    {
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Coordinate must be >= 0");
                    isValid = false;
                }
                else
                {
                    x = value;
                }
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Coordinate must be >= 0");
                    isValid = false;
                }
                else
                {
                    y = value;
                }
            }
        }
        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Coordinate must be >= 0");
                    isValid = false;
                }
                else
                {
                    z = value;
                }
            }
        }
        public bool IsValid
        {
            get
            {
                return isValid;
            }
        }

        private double x = 0;
        private double y = 0;
        private double z = 0;
        private bool isValid = true;

        public void Print()
        {
            Console.WriteLine($"X: {X}; Y: {Y}; Z: {Z}");
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
