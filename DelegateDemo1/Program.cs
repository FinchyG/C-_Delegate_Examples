using System;

namespace DelegateDemo1
{
    public delegate void MyDelegate(string msg);
    class Program
    {   
        static void Main(string[] args)
        {
            MyDelegate del = new MyDelegate(Class1.Method1);
            del("message 1");

            del = Class2.Method2;
            del("message 2");

            del = null;
        }
    }
}
