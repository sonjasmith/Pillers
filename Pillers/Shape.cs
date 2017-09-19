using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillers
{
    abstract class Shape
    {

        //shorthand way will create a field in the background
        public string Name { get; set; }

        //abstract forces you to include 
        abstract public double Area();
        public Shape(string name)
        {
            Name = name;
        }
        public void GetInfo()
        {
            Console.WriteLine("I am a {0}", Name);
        }


  
    }
}
