using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Models
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle has method :: draw()");
        }
    }
}
