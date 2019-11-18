using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_
{
    class Program
    {
        static void Main(string[] args)
        {
            // ShapeBase sb = new ShapeBase("circle", 6.7f); // error
            Circle c = new Circle("Circle-1", 9.5f, 4.2f);
            Console.WriteLine(c);
        }
    }
}
