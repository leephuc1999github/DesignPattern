using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factories
{
    public class ColorFactory : AbstractFactory
    {
        public override Color getColor(string color)
        {
            if (string.IsNullOrEmpty(color)) return null;
            if (color.Equals("green"))
            {
                return new Green();
            }
            else if (color.Equals("blue"))
            {
                return new Blue();
            }
            else if (color.Equals("red"))
            {
                return new Red();
            }
            return null;
        }

        public override Shape getShape(string shape)
        {
            throw new NotImplementedException();
        }
    }
}
