using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Models
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Circle has method :: draw()");
        }
    }
}
