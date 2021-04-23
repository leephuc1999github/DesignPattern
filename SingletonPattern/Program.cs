using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonObject so = SingletonObject.getInstance();
            so.showMessage();
        }
    }
}
