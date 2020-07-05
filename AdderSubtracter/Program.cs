using System;

namespace AdderSubtracter
{
    class Program
    {
        public delegate void MathsOperations(int x, int y);
        static void Main(string[] args)
        {
            MathsOperations MathsOps = Operations.Adder;
            MathsOps += Operations.Subtracter;

            Console.WriteLine("Please enter first number:");
            int x = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter first number:");
            int y = Convert.ToInt16(Console.ReadLine());

            MathsOps(x,y);

            MathsOps -= Operations.Adder;
            MathsOps -= Operations.Subtracter;
        }
    }
}
