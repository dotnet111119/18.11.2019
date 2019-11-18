using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _181119
{
    public abstract class Engine
    {
        public bool _working;
        public string _name;
        public float _size;

        protected Engine(bool working, string name, float size)
        {
            _working = working;
            _name = name;
            _size = size;
        }

        public override string ToString()
        {
            return $"WORKING: {_working} NAME : {_name} SIZE: {_size}";
        }
    }
}
