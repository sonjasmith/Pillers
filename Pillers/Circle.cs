using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pillers
{
    class Circle : IShape
    {
        public string Name { get; set; }
        public double Radius { get; set; }
        static int circleNumber;

        //public int CircleNumer
        //{
        //    get { return this.circleNumber; }
        //}

        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
            circleNumber += 1;
        }

        public double Area()
        {
            double pi = Math.PI;
            return pi * Math.Pow(Radius, 2);
        }

        public void GetInfo()
        {
            Console.WriteLine("I am a " + Name);
        }

        public void NumberOfCircles()
        {
            Console.WriteLine("The number of circles is " + circleNumber);
        }
    }
}
