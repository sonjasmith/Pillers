using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillers
{
    class Square : Shape
    {   
        //property
        public double Length { get; set; }
        //constructor
        public Square(string name, double length) : base(name)
        {
            Length = length;
        }

        public override double Area()
        {
            return Length * Length;
        }
    }
}
