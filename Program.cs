using System;

namespace Fibonacci_Iterative
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Fib_Iter(4);
        }

        public static void Fib_Iter(int len)
        {
            int a = 0, b = 1, c = 0;
            Console.Write($"{a} {b}");

            for(int x=0; x<len; x++)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
            }
        }
    }
}
