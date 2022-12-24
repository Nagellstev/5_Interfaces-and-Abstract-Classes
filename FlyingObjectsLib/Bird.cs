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
        public Coordinate initCoord = new Coordinate();
        public Coordinate finCoord = new Coordinate();
        public double Speed;

        public void FlyTo(Coordinate coordinate)
        {
            initCoord = finCoord;
            finCoord = coordinate;
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
                time = Distance(initCoord, finCoord) / Speed;
            }
            return time;
        }
        public double Distance(Coordinate init, Coordinate fin)
        {
            double distance;
            distance = Math.Sqrt(Math.Pow(fin.X - init.X, 2) + Math.Pow(fin.Y - init.Y, 2) + Math.Pow(fin.Z - init.Z, 2));
            return Math.Round(distance, 3);
        }
    }
}
