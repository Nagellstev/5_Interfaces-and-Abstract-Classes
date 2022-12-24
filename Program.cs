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

        bool endApp = false;
        bool endFighter = false;
        while (endApp != true)
        {
            Console.WriteLine("Choose your fighter:");
            Console.WriteLine("\t1: A bird");
            Console.WriteLine("\t2: A plane");
            Console.WriteLine("\t3: A drone");
            Console.WriteLine("And type number: ");

            Coordinate coord = new Coordinate();
            TimeSpan time;

            Bird bird = new Bird();
            Airplane plane = new Airplane();
            Drone drone = new Drone();

            switch (Console.ReadLine())
            {
                case "1":
                    endFighter = false;
                    while (endFighter != true)
                    {
                        coord.Input(InputX("X"), InputX("Y"), InputX("Z"));
                        bird.FlyTo(coord);
                        //bird.initCoord.Print();
                        //bird.finCoord.Print();
                        if (bird.GetFlyTime(coord) == 0)
                        {
                            time = TimeSpan.FromHours(0);
                            Console.WriteLine("I'm chicken, I won't fly!");
                        }
                        else
                        {
                            time = TimeSpan.FromHours(bird.GetFlyTime(coord));
                            Console.WriteLine("Bird's Flight Time: " + /*bird.GetFlyTime(coord)); //*/time.ToString(@"hh\:mm\:ss"));
                            Console.WriteLine("Bird's speed was: " + bird.Speed + "km/h");
                            Console.WriteLine("Covered distance: " + bird.Distance(bird.initCoord, bird.finCoord) + "km");
                        }
                        Console.WriteLine("Press 'n' and 'Enter' to exit or other key to fly further.\n");
                        if (Console.ReadLine() == "n")
                        {
                            endFighter = true;
                        }
                        Console.WriteLine("\n");
                    }
                    break;
                case "2":
                    endFighter = false;
                    while (endFighter != true)
                    {
                        coord.Input(InputX("X"), InputX("Y"), InputX("Z"));
                        plane.FlyTo(coord);
                        time = TimeSpan.FromHours(plane.GetFlyTime(coord));
                        Console.WriteLine("Plane's Flight Time: " + time.ToString(@"hh\:mm\:ss"));
                        Console.WriteLine("Plane's average speed was: " + plane.Speed + "km/h");
                        Console.WriteLine("Covered distance: " + plane.Distance(plane.initCoord, plane.finCoord) + "km");
                        Console.WriteLine("Press 'n' and 'Enter' to exit or other key to fly further.\n");
                        if (Console.ReadLine() == "n")
                        {
                            endFighter = true;
                        }
                        Console.WriteLine("\n");
                    }
                    break;
                case "3":
                    endFighter = false;
                    while (endFighter != true)
                    {
                        coord.Input(InputX("X"), InputX("Y"), InputX("Z"));
                        drone.FlyTo(coord);
                        if (drone.GetFlyTime(coord) == 0)
                        {
                            time = TimeSpan.FromHours(drone.GetFlyTime(coord));
                            Console.WriteLine("I won't fly. It's too far for me.");
                        }
                        else
                        {
                            time = TimeSpan.FromHours(drone.GetFlyTime(coord));
                            Console.WriteLine("Drone's Flight Time: " + time.ToString(@"hh\:mm\:ss"));
                            Console.WriteLine("Drones's average speed was: " + drone.Speed + "km/h");
                            Console.WriteLine("Covered distance: " + drone.Distance(drone.initCoord, drone.finCoord) + "km");
                        }
                        Console.WriteLine("Press 'n' and 'Enter' to exit or other key to fly further.\n");
                        if (Console.ReadLine() == "n")
                        {
                            endFighter = true;
                        }
                        Console.WriteLine("\n");
                    }
                    break;
                default:
                    Console.WriteLine("wdwd");
                    break;
            }
            Console.WriteLine("Press 'n' and 'Enter' to exit or other key to continue.\n");
            if (Console.ReadLine() == "n")
            {
                endApp = true;
            }
            Console.WriteLine("\n");
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



