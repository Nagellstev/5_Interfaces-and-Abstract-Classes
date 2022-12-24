using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using FlyingObj;

class Program
{
    static void Main()
    {
        Console.WriteLine("\tFlying objects");
        Console.WriteLine("\n");
        Console.WriteLine("Choose your fighter:");
        Console.WriteLine("\t1: A bird");
        Console.WriteLine("\t2: A plane");
        Console.WriteLine("\t3: A drone");
        Console.WriteLine("And type number: ");

        Coordinate coord = new Coordinate();
        TimeSpan time;

        switch (Console.ReadLine())
        {
            case "1":
                Bird bird = new Bird();
                coord.Input(InputX("X"), InputX("Y"), InputX("Z"));
                bird.FlyTo(coord);
                //bird.initCoord.Print();
                //bird.finCoord.Print();
                time = TimeSpan.FromHours(bird.GetFlyTime(coord));
                Console.WriteLine("Bird's Flight Time: " + time.ToString(@"hh\:mm\:ss"));
                Console.WriteLine("Bird's speed was: " + bird.Speed + "km/h");
                Console.WriteLine("Covered distance: " + bird.Distance(bird.initCoord, bird.finCoord) + "km");
                break;
            case "2":
                Airplane plane = new Airplane();
                coord.Input(InputX("X"), InputX("Y"), InputX("Z"));
                plane.FlyTo(coord);
                time = TimeSpan.FromHours(plane.GetFlyTime(coord));
                Console.WriteLine("Plane's Flight Time: " + time.ToString(@"hh\:mm\:ss"));
                Console.WriteLine("Plane's average speed was: " + plane.Speed + "km/h");
                Console.WriteLine("Covered distance: " + plane.Distance(plane.initCoord, plane.finCoord) + "km");
                break;
            case "3":
                Drone drone = new Drone();
                coord.Input(InputX("X"), InputX("Y"), InputX("Z"));
                drone.FlyTo(coord);
                time = TimeSpan.FromHours(drone.GetFlyTime(coord));
                Console.WriteLine("Drone's Flight Time: " + time.ToString(@"hh\:mm\:ss"));
                Console.WriteLine("Drones's average speed was: " + drone.Speed + "km/h");
                Console.WriteLine("Covered distance: " + drone.Distance(drone.initCoord, drone.finCoord) + "km");
                break;
            default:
                Console.WriteLine("wdwd");
                break;
        }
    }
    public static double InputX(string strX)
    {
        string XInput;
        Console.WriteLine("Type " + strX + ", press Enter");
        XInput = Console.ReadLine();
        double X = 0;
        while (!double.TryParse(XInput, out X))
        {
            Console.WriteLine("Input decimal number:");
            XInput = Console.ReadLine();
        }
        return X;
    }
}



