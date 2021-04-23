using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class SingletonObject
    {
        private static SingletonObject instance = new SingletonObject();
        private SingletonObject() { }
        public static SingletonObject getInstance()
        {
            return instance;
        } 
        public void showMessage()
        {
            Console.WriteLine("hello world");
        }
    }
}
