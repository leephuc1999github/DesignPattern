using AbstractFactoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factories
{
    public abstract class AbstractFactory
    {
        public abstract Shape getShape(string shape);
        public abstract Color getColor(string color);
    }
}
