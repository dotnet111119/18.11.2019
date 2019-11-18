using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181119
{
    public class SlowEngine : Engine
    {
        public int _minSpeed;
        public SlowEngine(int minSpeed, bool working, string name, float size) : base(working, name, size)
        {
            _minSpeed = minSpeed;
        }

        public override string ToString()
        {
            return $"{base.ToString()} MIN-SPEED : {_minSpeed}";
        }
    }
}

