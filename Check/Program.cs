using System;

namespace Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("");
            number = int.Parse(Console.ReadLine());
        }
        public static int Factorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
