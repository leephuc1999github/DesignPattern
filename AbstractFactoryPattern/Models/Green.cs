using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Models
{
    public class Green : Color
    {
        public void fill()
        {
            Console.WriteLine("Green has method :: fill()");
        }
    }
}
