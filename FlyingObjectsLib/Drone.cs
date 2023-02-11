using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingObjects
{
    /// <summary>
    /// Drones's speed is 20 km/h
    /// every 10 min of flight drone hovers for 1 min (it is processed in expression of time)
    /// max distance of flight is 100km. If distance > 100, time will be 0
    /// please, process it while using GetFlyTime in Drone class
    /// </summary>
    public class Drone : Bird
    {
        public override double GetFlyTime(Coordinate coordinate)
        {
            double speed = 20;
            double time = 0;
            double distance = Distance(InitialCoord, FinalCoord);

            if (distance > 100)
            {
                time = 0;
            }
            else
            {
                time = distance / speed + Math.Floor(distance / speed / 10);
            }

            Speed = distance / time;

            return time;
        }
    }
}