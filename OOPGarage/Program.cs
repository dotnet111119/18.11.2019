using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181119
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            SportCar sport1 = new SportCar(230, new SportEngine(8, true, "PONTIAC", 5800)); // inline

            // 2
            Engine e = new SportEngine(8, true, "FERRARI", 5800);
            SportCar sport2 = new SportCar(230, e);

            // 3 - engine not working!
            SportCar sport3 = new SportCar(8, new SlowEngine(50, false, "SUSITA", 1200));

            Console.WriteLine("Sport3 before fix");
            Console.WriteLine(sport3); // before fix
            //sport3.FixMyEngine(new Garage()); // inline
            Garage g = new Garage();
            sport3.FixMyEngine(g);
            Console.WriteLine("Sport3 after fix");
            Console.WriteLine(sport3); // after fix

            Car[] cars = new Car[3];
            cars[0] = sport1;
            cars[1] = sport2;
            cars[2] = sport3;
            Parking p = new Parking(cars);
            Console.WriteLine("Parking:");
            Console.WriteLine(p);

        }
    }
}
