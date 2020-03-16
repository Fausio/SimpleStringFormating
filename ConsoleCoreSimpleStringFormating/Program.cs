using System;

namespace ConsoleCoreSimpleStringFormating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add the first number");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Now add the secund number");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;

            Console.WriteLine("the sum of {0} and {1} is: {2}", a, b, c);
            Console.ReadKey();
        }
    }
}
