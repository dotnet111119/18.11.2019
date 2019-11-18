using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181119
{
    public class Parking
    {
        public Car[] _cars;

        public Parking(Car[] cars)
        {
            _cars = cars;
        }

        public override string ToString()
        {
            string result = "";
            foreach (Car c in _cars)
            {
                result += c.ToString() + "\n";
            }
            return result;
        }
    }
}
