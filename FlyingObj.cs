namespace FlyingObj
{
    interface IFlyable
    {
        void FlyTo(Coordinate coordinate);
        double GetFlyTime(Coordinate coordinate);
    }

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
            double d;
            d = Math.Sqrt(Math.Pow(fin.X - init.X, 2) + Math.Pow(fin.Y - init.Y, 2) + Math.Pow(fin.Z - init.Z, 2));
            return d;
        }
    }
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
            double d = Distance(initCoord, finCoord);
            double currDist = 0;
            while (currDist < d)
            {
                currDist += 10;
                time += 10 / speed;
                speed += 10;
            }
            time += (d - currDist + 10) / speed;
            Speed = d / time;
            return time;
        }
    }
    /// <summary>
    /// Drones's speed is 20 km/h
    /// every 10 min of flight drone hovers for 1 min (it processed in formula of time)
    /// max distance of flight is 100km. If distance > 100, time will be 0
    /// please, process it while using GetFlyTime in Drone class
    /// </summary>
    public class Drone : Bird
    {
        public override double GetFlyTime(Coordinate coordinate)
        {
            double speed = 20;
            double time = 0;
            double d = Distance(initCoord, finCoord);
            if (d > 100)
            {
                time = 0;
            }
            else
            {
                time = d / speed + Math.Floor(d / speed / 10);
            }
            Speed = d / time;
            return time;
        }
    }
}