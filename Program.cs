/// See README.md for description

using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using FlyingObjects;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("\tFlying objects");
        Console.WriteLine("\n");

        bool isEndApp = false;
        bool isEndFighter = false;

        while (isEndApp != true)
        {
            Console.WriteLine("Choose your fighter:");
            Console.WriteLine("\t1: A bird");
            Console.WriteLine("\t2: A plane");
            Console.WriteLine("\t3: A drone");
            Console.WriteLine("\t4: Exit");
            Console.WriteLine("And type number: ");

            Coordinate coordinates = new Coordinate();
            TimeSpan time;

            Bird bird = new Bird();
            Airplane plane = new Airplane();
            Drone drone = new Drone();

            switch (Console.ReadLine())
            {
                case "1":
                    isEndFighter = false;

                    while (isEndFighter != true)
                    {
                        coordinates.Input(InputX("X"), InputX("Y"), InputX("Z"));

                        if (coordinates.IsValid())
                        {
                            bird.FlyTo(coordinates);
                        }
                        else
                        {
                            Console.WriteLine("Coordinates is not valid!");
                            break;
                        }

                        if (bird.GetFlyTime(coordinates) == 0)
                        {
                            time = TimeSpan.FromHours(0);
                            Console.WriteLine("I'm chicken, I won't fly!");
                        }
                        else
                        {
                            time = TimeSpan.FromHours(bird.GetFlyTime(coordinates));

                            Console.WriteLine($"Bird's Flight Time: {time.ToString(@"hh\:mm\:ss")}");
                            Console.WriteLine($"Bird's speed was: {bird.Speed} km/h");
                            Console.WriteLine($"Covered distance: {bird.Distance(bird.InitialCoord, bird.FinalCoord)} km");
                        }

                        Console.WriteLine("\n");
                        Console.WriteLine("Press 'q' and 'Enter' to go to the first menu or other key to fly further.\n");

                        if (Console.ReadLine() == "q")
                        {
                            isEndFighter = true;
                        }

                        Console.WriteLine("\n");
                    }
                    break;

                case "2":
                    isEndFighter = false;

                    while (isEndFighter != true)
                    {
                        coordinates.Input(InputX("X"), InputX("Y"), InputX("Z"));

                        if (coordinates.IsValid())
                        {
                            plane.FlyTo(coordinates);
                        }
                        else
                        {
                            Console.WriteLine("Coordinates is not valid!");
                            break;
                        }

                        time = TimeSpan.FromHours(plane.GetFlyTime(coordinates));

                        Console.WriteLine($"Plane's Flight Time: {time.ToString(@"hh\:mm\:ss")}");
                        Console.WriteLine($"Plane's average speed was: {plane.Speed} km/h");
                        Console.WriteLine($"Covered distance: {plane.Distance(plane.InitialCoord, plane.FinalCoord)} km");
                        Console.WriteLine("\n");
                        Console.WriteLine("Press 'q' and 'Enter' to go to the first menu or other key to fly further.\n");

                        if (Console.ReadLine() == "q")
                        {
                            isEndFighter = true;
                        }

                        Console.WriteLine("\n");
                    }
                    break;

                case "3":
                    isEndFighter = false;

                    while (isEndFighter != true)
                    {
                        coordinates.Input(InputX("X"), InputX("Y"), InputX("Z"));

                        if (coordinates.IsValid())
                        {
                            drone.FlyTo(coordinates);
                        }
                        else
                        {
                            Console.WriteLine("Coordinates is not valid!");
                            break;
                        }

                        if (drone.GetFlyTime(coordinates) == 0)
                        {
                            time = TimeSpan.FromHours(drone.GetFlyTime(coordinates));

                            Console.WriteLine("I won't fly. It's too far for me.");
                        }
                        else
                        {
                            time = TimeSpan.FromHours(drone.GetFlyTime(coordinates));

                            Console.WriteLine($"Drone's Flight Time: {time.ToString(@"hh\:mm\:ss")}");
                            Console.WriteLine($"Drones's average speed was: {drone.Speed} km/h");
                            Console.WriteLine("\n");
                            Console.WriteLine($"Covered distance: {drone.Distance(drone.InitialCoord, drone.FinalCoord)} km");
                        }

                        Console.WriteLine("Press 'q' and 'Enter' to go to the first menu or other key to fly further.\n");

                        if (Console.ReadLine() == "q")
                        {
                            isEndFighter = true;
                        }
                        Console.WriteLine("\n");
                    }
                    break;

                case "4":
                    isEndApp = true;

                    break;

                default:
                    Console.WriteLine("wdwd");

                    break;
            }
        }
    }

    private static double InputX(string inputCoordinate)
    {
        string xInput;

        Console.WriteLine($"Type {inputCoordinate}, press Enter");
        xInput = Console.ReadLine();

        double x = 0;

        while (!double.TryParse(xInput, out x) || 
            x < 0)
        {
            Console.WriteLine("Input decimal number >= 0:");
            xInput = Console.ReadLine();
        }

        return x;
    }
}



