using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Models;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory af = FactoryProducer.getFactory("shape");
            Shape s = af.getShape("circle");
            s.draw();
        }
        
    }
    class FactoryProducer
    {
        public static AbstractFactory getFactory(string type)
        {
            if (string.IsNullOrEmpty(type)) return null;
            if (type.Equals("shape")) return new ShapeFactory();
            else if (type.Equals("color")) return new ColorFactory();
            else return null;
        }
    }
}
