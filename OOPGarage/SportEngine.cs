using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181119
{
    public class SportEngine : Engine
    {
        public int _cylinder;
        public SportEngine(int cylinder, bool working, string name, float size) : base(working, name, size)
        {
            _cylinder = cylinder;
        }

        public override string ToString()
        {
            return $"{base.ToString()} CYLINDER : {_cylinder}";
        }
    }
}
