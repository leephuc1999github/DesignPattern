using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Models
{
    public class Red : Color
    {
        public void fill()
        {
            Console.WriteLine("Red has method :: fill()");
        }
    }
}
