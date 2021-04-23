using FactoryPattern.Factories;
using FactoryPattern.Models;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sf = new ShapeFactory();
            Shape s = sf.getShapeFactory("circle");
            s.draw();
        }
    }
}
