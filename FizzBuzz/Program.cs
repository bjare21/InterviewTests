using System;

namespace FizzBuzz
{
    class Program
    {
        private static void Print()
        {
            for (int i=1; i <= 100; i++)
            {
                Console.Write("\n" + i);
                if (i % 3 == 0)
                {
                    Console.Write(" Fizz");
                }
                if (i % 5 == 0)
                {
                    Console.Write(" Buzz");
                }
            }
        }

        static void Main(string[] args)
        {
            Print();
        }
    }
}
