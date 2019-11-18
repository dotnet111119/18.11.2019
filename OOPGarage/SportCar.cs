using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181119
{
    public class SportCar : Car
    {
        public int _horsePower;

        public SportCar(int horsePower, Engine engine) : base(engine)
        {
            _horsePower = horsePower;
        }

        public override void Go()
        {
            Console.WriteLine($"Driving sport car with {_horsePower} horse power!");
        }
    }
}
