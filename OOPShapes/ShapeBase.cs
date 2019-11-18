using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_
{
    public abstract class ShapeBase
    {
        public string _name;
        public double _area;

        //public ShapeBase()
        //{

        //}

        public ShapeBase(string name, double area)
        {
            _name = name;
            _area = area;
        }

        public void PrintName()
        {
            Console.WriteLine($"Shape name is : {_name}");
        }

        public abstract void CalcArea();

        public override string ToString()
        {
            return $"NAME: {_name} AREA: {_area}";
        }
    }
}
