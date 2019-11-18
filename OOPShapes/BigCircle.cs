using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_
{
    class BigCircle : Circle
    {
        public BigCircle() : base(null, 0, 0)
        {
            this.CalcArea();
            base.CalcArea();
        }
        public override void CalcArea()
        {

        }

    }
}
