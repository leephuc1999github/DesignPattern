using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.Models
{
    public interface Item
    {
        public string name();
        public Packing packing();
        public float price();
    }
}
