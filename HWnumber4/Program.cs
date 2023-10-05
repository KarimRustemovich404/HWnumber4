using System;

namespace HWnumber4Laboratorka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N1, N2;

            Console.WriteLine("Упражнение 5.1 Метод возвращает наибольшее из двух значений.\nВведите первое значение:");
            N1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе значение: ");
            N2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Наибольшее значение из двух данных:" + GetMax(N1, N2));
        }
        public static int GetMax(int N1, int N2)
        {
            if (N1 > N2)
            {
                return N1;
            }
            else
            {
                return N2;
            }

        }
    }
}




internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Домашнее задание 5.2 Вычисление НОДа двух натуральных чисел\nВведите первое значение:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine(SmallestDivisor(n, d));
    }


    public static int SmallestDivisor(int n, int d)
    {
        if (n % d == 0)
        {
            return d;
        }
        else
        {
            return SmallestDivisor(n, d + 1);


        }
    }
}



internal class Program
{
    static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Упражнение 5.4 Рекурсивный метод вычисления факториала числа\nВведите число ");
        number = int.Parse(Console.ReadLine());
    }
    public static int RecursiveFactorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * RecursiveFactorial(number - 1);
        }
    }
}
