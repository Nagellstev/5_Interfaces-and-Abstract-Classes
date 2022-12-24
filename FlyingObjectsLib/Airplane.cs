using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingObjects
{
    /// <summary>
    /// Airplane's initial speed is 200 km/h
    /// every 10 km speed increases at 10km/h
    /// </summary>
    public class Airplane : Bird
    {
        public override double GetFlyTime(Coordinate coordinate)
        {
            double speed = 200;
            double time = 0;
            double distance = Distance(initCoord, finCoord);
            double currDist = 0;
            while (currDist < distance)
            {
                currDist += 10;
                time += 10 / speed;
                speed += 10;
            }
            time += (distance - currDist + 10) / speed;
            Speed = distance / time;
            return time;
        }
    }
}
