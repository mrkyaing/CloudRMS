using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.O
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()=> Radius * Radius * 3.14;

    }
}
