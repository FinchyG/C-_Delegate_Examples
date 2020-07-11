using System;

namespace NameGreeting
{
    public delegate string GreetingDelegate(string str);
    class Program
    {
        static void Main(string[] args)
        {
            GreetingDelegate g1 = new GreetingDelegate(Greeting.GreetingMethod);

            Console.WriteLine(g1("Luke"));
        }
    }
}
