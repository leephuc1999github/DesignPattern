using FactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Factories
{
    public class ShapeFactory
    {
        public Shape getShapeFactory(string typeShape)
        {
            if (string.IsNullOrEmpty(typeShape))
            {
                return null;
            }
            if (typeShape.Equals("circle"))
            {
                return new Circle();
            }
            else if (typeShape.Equals("square"))
            {
                return new Square();
            }
            else if (typeShape.Equals("rectangle"))
            {
                return new Rectangle();
            }
            return null;
        }
    }
}
