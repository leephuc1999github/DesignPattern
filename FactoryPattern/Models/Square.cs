using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Models
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square has method :: draw()");
        }
    }
}
