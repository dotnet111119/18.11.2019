using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_
{
    public abstract class Circle : ShapeBase
    {
        public double _radius;

        // overloading - same function with different parameters
        // ctor overloading

        public Circle(string name, double area, double radius) : base(name, area)
        {
            //_area = area;
            _radius = radius;
        }

        //public void CalcArea()
        //{

        //    _area = Math.PI * Math.Pow(_radius, 2);
        //}

        public override void CalcArea()
        {

        }

        public override string ToString()
        {
            return $"{base.ToString()} RADIUS: {_radius }";
        }
    }
}
