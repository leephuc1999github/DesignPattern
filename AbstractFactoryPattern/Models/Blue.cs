using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Models
{
    public class Blue : Color
    {
        public void fill()
        {
            Console.WriteLine("Blue has method :: fill()");
        }
    }
}
