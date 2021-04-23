using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factories
{
    public class ShapeFactory : AbstractFactory
    {
        public override Color getColor(string color)
        {
            throw new NotImplementedException();
        }

        public override Shape getShape(string shape)
        {
            if (string.IsNullOrEmpty(shape)) return null;
            if (shape.Equals("circle"))
            {
                return new Circle();
            }
            else if (shape.Equals("Square"))
            {
                return new Square();
            }
            else if (shape.Equals("Rectangle"))
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
