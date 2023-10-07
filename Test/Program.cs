using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static int GetMax(int N1, int N2)
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
        static void Task_UPR_5_1()
        {
            Console.WriteLine("Введите число:");
            bool isNumber1 = int.TryParse(Console.ReadLine(), out int number1);
            bool isNumber2 = int.TryParse(Console.ReadLine(), out int number2);

            int result;
            if(isNumber1 & isNumber2)
            {
                result=GetMax(number1, number2);
                Console.WriteLine("Результат - ", result);
            }
            else
            {
                Console.WriteLine("Ошибка ввода");
            }
            
        }
        static void Task_UPR_5_2()
        {

        }
        static void Task_UPR_5_3()
        {

        }
        static void Task_UPR_5_4()
        {

        }
        static void Task_DZ_5_1()
        {

        }
        static void Task_DZ_5_2()
        {

        }
        static void Main(string[] args)
        {
            Task_UPR_5_1();
            Task_UPR_5_2();
            Task_UPR_5_3();
            Task_UPR_5_4();
            Task_DZ_5_1();
            Task_DZ_5_2();

            Console.ReadKey();
        }
    }
}
