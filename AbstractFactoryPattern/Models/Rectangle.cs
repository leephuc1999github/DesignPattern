using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Models
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle has method :: draw()");
        }
    }
}
