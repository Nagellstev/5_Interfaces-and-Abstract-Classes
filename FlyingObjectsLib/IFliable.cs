using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingObjects
{
    interface IFlyable
    {
        void FlyTo(Coordinate coordinate);
        double GetFlyTime(Coordinate coordinate);
    }
}
