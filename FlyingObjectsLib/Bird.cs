using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingObjects
{
    /// <summary>
    /// Bird's speed is random in rane 0 - 20 km/h
    /// if speed is 0, time also will be 0
    /// please, process this while using GetFlyTime in Bird class
    /// </summary>
    public class Bird : IFlyable
    {
        public Coordinate InitialCoordinates = new Coordinate();
        public Coordinate FinalCoordinates = new Coordinate();
        public double Speed;

        public void FlyTo(Coordinate coordinate)
        {
            InitialCoordinates = FinalCoordinates;
            FinalCoordinates = coordinate;
        }

        public virtual double GetFlyTime(Coordinate coordinate)
        {
            Random rnd = new Random();
            Speed = rnd.Next(20);
            double time = 0;

            if (Speed == 0)
            {
                time = 0;
            }
            else
            {
                time = Distance(InitialCoordinates, FinalCoordinates) / Speed;
            }

            return time;
        }

        public double Distance(Coordinate initial, Coordinate final)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow(final.X - initial.X, 2) + Math.Pow(final.Y - initial.Y, 2) + Math.Pow(final.Z - initial.Z, 2));

            return Math.Round(distance, 3);
        }
    }
}
