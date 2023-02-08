using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciple.O{
    public class Square:Shape{
        public int side { get; set; }

        public override double Area()=> side * side;       
    }
}
