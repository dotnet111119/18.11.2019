using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181119
{
    public abstract class Car
    {
        public Engine _engine;

        public Car(Engine engine)
        {
            _engine = engine;
        }

        public abstract void Go();

        public void FixMyEngine(Garage g)
        {
            g.FixEngine(_engine);
        }

        public override string ToString()
        {
            return $"ENGINE: {_engine.ToString()} ";
        }
    }
}
